using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using TravelAgency.Data;
using TravelAgency.Data.Models;
using TravelAgency.DataProcessor.ImportDtos;
using TravelAgency.Utilities;

namespace TravelAgency.DataProcessor
{
    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data format!";
        private const string DuplicationDataMessage = "Error! Data duplicated.";
        private const string SuccessfullyImportedCustomer = "Successfully imported customer - {0}";
        private const string SuccessfullyImportedBooking = "Successfully imported booking. TourPackage: {0}, Date: {1}";

        public static string ImportCustomers(TravelAgencyContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlHelper xmlHelper = new XmlHelper();
            const string xmlRoot = "Customers";


            ICollection<Customer> customersToImport = new HashSet<Customer>();

            ImportCustomerDto[] deserializedCustomers = xmlHelper.Deserialize<ImportCustomerDto[]>(xmlString, xmlRoot);

            foreach (ImportCustomerDto customerDto in deserializedCustomers)
            {
                if (!IsValid(customerDto))
                {
                    sb.AppendLine(ErrorMessage); 
                    continue;
                }

                if (customersToImport.Any(c => c.FullName == customerDto.FullName 
                                       || c.Email == customerDto.Email 
                                       || c.PhoneNumber == customerDto.PhoneNumber)) 
                {
                    sb.AppendLine(DuplicationDataMessage);
                    continue;
                }

                Customer newClient = new Customer()
                {
                    PhoneNumber = customerDto.PhoneNumber,
                    FullName = customerDto.FullName,
                    Email = customerDto.Email,
                };

                customersToImport.Add(newClient);
                sb.AppendLine(string.Format(SuccessfullyImportedCustomer, customerDto.FullName));
            }

            context.AddRange(customersToImport);
            context.SaveChanges();

            return sb.ToString();
        }

        public static string ImportBookings(TravelAgencyContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ICollection<Booking> bookignsToImport = new List<Booking>();

            ImportBookingDto[] deserializedBookings = JsonConvert.DeserializeObject<ImportBookingDto[]>(jsonString)!;

            foreach (ImportBookingDto bookingDto in deserializedBookings)
            {
                if (!IsValid(bookingDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                bool isBookingDateValid = DateTime.TryParseExact(bookingDto.BookingDate, "yyyy-MM-dd", 
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime issueDate);

                if (!isBookingDateValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (!context.Customers.Any(c => c.FullName == bookingDto.CustomerName ||                
                    !context.TourPackages.Any(t => t.PackageName == bookingDto.TourPackageName)))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Customer bookingCustomer = context.Customers.FirstOrDefault(c => c.FullName == bookingDto.CustomerName)!;
                TourPackage bookingTourPackage = context.TourPackages.FirstOrDefault(t => t.PackageName == bookingDto.TourPackageName)!;

                Booking booking = new Booking()
                {
                    BookingDate = DateTime.Parse(bookingDto.BookingDate, CultureInfo.InvariantCulture),
                    CustomerId = bookingCustomer.Id,
                    Customer = bookingCustomer,
                    TourPackageId = bookingTourPackage.Id,
                    TourPackage = bookingTourPackage
                };

                bookignsToImport.Add(booking);
                sb.AppendLine(string.Format(SuccessfullyImportedBooking, bookingDto.TourPackageName, bookingDto.BookingDate));
            }

            context.Bookings.AddRange(bookignsToImport);
            context.SaveChanges();

            return sb.ToString();
        }

        public static bool IsValid(object dto)
        {
            var validateContext = new ValidationContext(dto);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(dto, validateContext, validationResults, true);

            foreach (var validationResult in validationResults)
            {
                string currValidationMessage = validationResult.ErrorMessage;
            }

            return isValid;
        }
    }
}
