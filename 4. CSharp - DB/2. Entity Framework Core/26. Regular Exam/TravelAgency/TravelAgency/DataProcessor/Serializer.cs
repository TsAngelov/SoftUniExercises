using Newtonsoft.Json;
using TravelAgency.Data;
using TravelAgency.Data.Models.Enums;
using TravelAgency.DataProcessor.ExportDtos;
using TravelAgency.Utilities;

namespace TravelAgency.DataProcessor
{
    public class Serializer
    {
        public static string ExportGuidesWithSpanishLanguageWithAllTheirTourPackages(TravelAgencyContext context)
        {
            XmlHelper xmlHelper = new XmlHelper();
            const string xmlRoot = "Guides";

            ExportGuideDto[] guidesToExport = context.Guides
                .Where(g => g.Language == (Language)3)
                .Select(g => new ExportGuideDto()
                {
                    FullName = g.FullName,
                    TourPackages = g.TourPackagesGuides
                        .Select(tp => new ExportGuideTourPackageDto()
                        {
                            Name = tp.TourPackage.PackageName,
                            Description = tp.TourPackage.Description,
                            Price = tp.TourPackage.Price,
                        })
                        .OrderByDescending(tp => tp.Price)
                        .ThenBy(tp => tp.Name)
                        .ToArray()
                })
                .OrderByDescending(g => g.TourPackages.Count())
                .ThenBy(g => g.FullName)
                .ToArray();

            return xmlHelper.Serialize(guidesToExport, xmlRoot);
        }


            public static string ExportCustomersThatHaveBookedHorseRidingTourPackage(TravelAgencyContext context)
        {
            ExportCustomerDto[] customersToExport = context.Customers
                .Where(c => c.Bookings.Any(b => b.TourPackage.PackageName == "Horse Riding Tour"))
                .Select(p => new ExportCustomerDto()
                {
                    FullName = p.FullName,
                    PhoneNumber = p.PhoneNumber,
                    Bookings = p.Bookings
                        .Where(b => b.TourPackage.PackageName == "Horse Riding Tour")
                        .Select(b => new ExportCustomerBookingsDto()
                        {
                            TourPackageName = b.TourPackage.PackageName,
                            Date = b.BookingDate.ToString("yyyy-MM-dd")
                        })
                        .OrderBy(b => b.Date)
                        .ToArray()
                })
                .OrderByDescending(c => c.Bookings.Count())
                .ThenBy(c => c.FullName)
                .ToArray();

            return JsonConvert.SerializeObject(customersToExport, Formatting.Indented);
        }
    }
}
