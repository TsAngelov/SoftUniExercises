window.addEventListener("load", solve);

function solve() {
  const createParagraph = (label, text) => {
    const paragraph = document.createElement('p');

    const labelElement = document.createElement('strong');
    labelElement.textContent = label;

    paragraph.appendChild(labelElement);
    paragraph.appendChild(document.createElement('br'));
    paragraph.appendChild(document.createTextNode(text));

    return paragraph;
  };

  const emailInput = document.getElementById('email');
  const eventInput = document.getElementById('event');
  const locationInput = document.getElementById('location');
  const nextButton = document.getElementById('next-btn');
  const previewList = document.getElementById('preview-list');
  const eventList = document.getElementById('event-list');

  nextButton.addEventListener('click', () => {
    const email = emailInput.value.trim();
    const event = eventInput.value.trim();
    const location = locationInput.value.trim();

  if ( ! email || ! event || ! location) return;

  const listItem = document.createElement('li');
  listItem.classList.add('application');

  const article = document.createElement('article');

  const emailParagraph = document.createElement('h4');
  emailParagraph.textContent = email;
  article.appendChild(emailParagraph);

  const eventParagraph = createParagraph('Event:', event);
  const locationParagraph = createParagraph('Location:', location);

  article.appendChild(eventParagraph);
  article.appendChild(locationParagraph);

  listItem.appendChild(article);

  const editButton = document.createElement('button');
  editButton.textContent = 'edit';
  editButton.className = 'action-btn edit'

  const applyButton = document.createElement('button');
  applyButton.textContent = 'apply';
  applyButton.className = 'action-btn apply';

  listItem.appendChild(editButton);
  listItem.appendChild(applyButton);
  previewList.appendChild(listItem);

  emailInput.value = '';
  eventInput.value = '';
  locationInput.value = '';
  nextButton.disabled = true;

  editButton.addEventListener('click', () => {
    emailInput.value = email;
    eventInput.value = event;
    locationInput.value = location;

    previewList.removeChild(listItem);

    nextButton.disabled = false;
  });

  applyButton.addEventListener('click', () => {

    previewList.removeChild(listItem);

    listItem.removeChild(editButton);
    listItem.removeChild(applyButton);
    eventList.appendChild(listItem);

    nextButton.disabled = false;
    });
  });

  [emailInput, eventInput, locationInput].forEach(input => {
    
    input.addEventListener('input', () => {
      nextButton.disabled = !(
        emailInput.value.trim() &&
        eventInput.value.trim() &&
        locationInput.value.trim()
      );
    });
  });
}
