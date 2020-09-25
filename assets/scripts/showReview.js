let showReview = document.querySelector('.show-review');
let feed = document.querySelector('.home-page-feed');
let showContacts = document.querySelector('.home-page-show-contacts');
let closeBlock = document.querySelector('.home-page-section-button-review');

feed.addEventListener('click', function () {
    showContacts.style="display: none";
    showReview.style="display: block";
});

closeBlock.addEventListener('click', function () {
    showContacts.style="display: block";
    showReview.style="display: none";
});