@import url(./fonts.css);
* {
  margin: 0;
  padding: 0; }

.fade2 {
  animation-name: fade2;
  animation-duration: 2.5s; }

@keyframes fade2 {
  from {
    transform: translate(-15%, 0); }
  to {
    transform: translate(0, 0); } }
label {
  cursor: pointer; }

ul {
  list-style: none; }

.list {
  display: none; }

.list a {
  color: #333;
  text-decoration: none;
  transition: 0.5s; }
  .list a:hover {
    color: #f78e6a; }

.checkbox {
  display: none; }

.checkbox:checked ~ .list {
  display: block; }

#nav-icon4 {
  width: 20px;
  position: relative;
  transform: rotate(0deg);
  transition: .5s ease-in-out;
  cursor: pointer; }
  #nav-icon4 p {
    padding-left: 25px; }

#nav-icon4 span {
  display: block;
  position: absolute;
  margin: auto;
  height: 2px;
  width: 100%;
  background: #d3531a;
  border-radius: 9px;
  opacity: 1;
  left: 0;
  transform: rotate(0deg);
  transition: .25s ease-in-out; }

#nav-icon4 span:nth-child(1) {
  top: 0px;
  transform-origin: left center; }

#nav-icon4 span:nth-child(2) {
  top: 9px;
  transform-origin: left center; }

#nav-icon4 span:nth-child(3) {
  top: 18px;
  transform-origin: left center; }

#nav-icon4.open span:nth-child(1) {
  transform: rotate(45deg);
  top: 2px;
  left: 5px; }

#nav-icon4.open span:nth-child(2) {
  width: 0%;
  opacity: 0; }

#nav-icon4.open span:nth-child(3) {
  transform: rotate(-45deg);
  top: 17px;
  left: 5px; }

#nav-icon4.open ul {
  display: block; }

.home-page {
  background: #fbf5f4;
  font-family: "Geometria-Light";
  font-size: 1.8vh;
  line-height: 20px;
  color: #333;
  /*section 1*/ }
  .home-page__container {
    width: 85%;
    margin: 0 auto; }
  .home-page__menu {
    top: 4.8%;
    left: 5%;
    position: fixed;
    z-index: 100;
    font-family: 'Geometria';
    font-size: 2vh;
    display: flex;
    align-items: center;
    justify-content: space-between; }
  .home-page__phone {
    top: 5%;
    right: 5%;
    position: fixed;
    z-index: 100;
    font-family: 'Geometria';
    font-size: 2vh; }
  .home-page__logo {
    top: 50%;
    left: 5%;
    position: fixed;
    z-index: 100;
    font-family: 'Geometria';
    font-size: 2vh; }
  .home-page__social {
    bottom: 5%;
    left: 5%;
    position: fixed;
    z-index: 100;
    font-family: 'Geometria';
    font-size: 2vh; }
  .home-page__section-button {
    font-family: 'Geometria';
    outline: none;
    border: none;
    margin-right: 10px; }
  .home-page__social-link {
    text-decoration: none;
    color: #000;
    font-size: 1.2vh;
    margin-left: 15px; }
  .home-page__section-logo {
    grid-column: 2 / 4;
    grid-row: 1 / 2; }
  .home-page__section-1 .home-page__section-logo {
    grid-column: 3 / 4; }
  .home-page__section-content {
    display: grid;
    grid-template-columns: 0.5fr 1fr 1fr 0.5fr;
    align-items: center;
    margin: 0 auto;
    height: 95vh; }
  .home-page__image {
    grid-column: 2 / 3;
    grid-row: 1 / 2; }
  .home-page__section-image {
    grid-column: 2 / 3;
    grid-row: 1 / 2; }
  .home-page__section-name {
    text-align: center;
    position: relative;
    top: 45px;
    font-family: 'Geometria'; }
    .home-page__section-name p::before {
      content: '\260E';
      color: #f78e6a; }
  .home-page__section-description {
    display: flex;
    align-items: center;
    margin-top: 25px; }
  .home-page__text {
    font-size: 1.9vh;
    line-height: 1.6em;
    width: 600px;
    margin-top: 4vh; }
  .home-page__section-button {
    width: 6.4vh;
    height: 6.4vh;
    border-radius: 100%;
    background: url("../images/button.png") no-repeat 50% 50%;
    background-size: contain;
    transition: all 400ms ease; }
    .home-page__section-button:hover {
      background: url("../images/buttonw.png") no-repeat 50% 50%;
      background-size: contain;
      box-shadow: 0 0 1vh 0 rgba(0, 0, 0, 0.2); }
  .home-page__section-number {
    text-align: right;
    grid-column: 4 / 5;
    grid-row: 1 / 2; }
    .home-page__section-number p {
      line-height: 1em;
      color: #f78e6a;
      background: linear-gradient(0deg, #f78e6a, #FC66A2);
      -webkit-background-clip: text;
      -webkit-text-fill-color: transparent; }
      .home-page__section-number p:first-child {
        margin-bottom: 2vh;
        font-size: 7.6vh; }
      .home-page__section-number p:last-child {
        font-size: 3.2vh; }
  .home-page__section-follow {
    display: flex;
    justify-content: flex-end;
    margin-top: -70px;
    align-items: center;
    font-family: 'Geometria';
    text-decoration: none;
    color: #333; }
    .home-page__section-follow:hover {
      color: #f78e6a; }
    .home-page__section-follow p {
      cursor: pointer;
      transition: 0.5s; }
  .home-page__follow-button {
    margin-left: 10px;
    width: 30px;
    height: 30px;
    background: url("../images/icon.png") no-repeat 50% 50%;
    background-size: contain;
    outline: none;
    border: none;
    cursor: pointer; }
  .home-page__list {
    display: flex;
    flex-direction: column;
    cursor: pointer;
    list-style-type: none;
    line-height: 30px;
    margin: 0 auto;
    font-size: 1.9vh;
    grid-column: 1 / 2;
    grid-row: 1 / 2; }
  .home-page__title {
    color: #f78e6a;
    background: linear-gradient(0deg, #f78e6a, #FC66A2);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    color: #f78e6a;
    font-size: 5.1vh;
    height: 48px; }
  .home-page__secondary-title {
    font-size: 5.1vh;
    font-family: 'Geometria-Light';
    line-height: 50px; }
  .home-page__type {
    font-size: 2.5vh; }
  .home-page__form {
    display: flex;
    flex-direction: column;
    margin: 0 0 -20px; }
  .home-page__input {
    width: 48vh;
    height: 6vh;
    padding: auto 2vh;
    border: none;
    border-bottom: 1px solid #000;
    font-size: 1.7vh;
    line-height: 1em;
    margin-bottom: 1.5vh;
    outline: none;
    background: none;
    font-family: 'Geometria'; }
  .home-page__submit {
    display: flex;
    margin-top: 2vh;
    height: 45px;
    padding: 0 50px 0 8vh;
    align-items: center;
    border-radius: 3.2vh;
    background: url("../images/button1.png") no-repeat #f78e6a 0px 50%;
    background-size: contain;
    transition: all 400ms ease;
    color: #fff;
    line-height: 1em;
    font-size: 1.7vh;
    outline: none;
    border: none;
    font-family: 'Geometria';
    width: 35vh; }
    .home-page__submit:hover {
      background: url("../images/button1.png") no-repeat #fff 0px 50%;
      background-size: contain;
      color: #f78e6a;
      box-shadow: 0 0 1vh 0 rgba(0, 0, 0, 0.2); }
  .home-page__card-container {
    display: grid;
    grid-template-columns: repeat(2, 35vh); }
  .home-page__card {
    margin: 0 0.4vh 0.4vh 0;
    padding: 0 3vh 0 4vh;
    align-items: center;
    background: #fff;
    transition: box-shadow 400ms ease;
    display: flex;
    font-family: 'Geometria';
    height: 14vh;
    justify-content: space-between; }
    .home-page__card:hover {
      box-shadow: 0 0 1vh 0 rgba(0, 0, 0, 0.2); }
  .home-page__card-title {
    color: #f78e6a;
    background: linear-gradient(0deg, #f78e6a, #FC66A2);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    color: #f78e6a;
    font-size: 1.9vh;
    font-weight: 700; }
  .home-page__card-secondary-title {
    padding-top: 35px; }
  .home-page__reviews-name-container {
    display: flex; }
  .home-page__reviews-name {
    display: flex;
    flex-direction: column;
    justify-content: flex-end;
    padding: 0 0 15px 15px; }
  .home-page__table-content {
    grid-column: 1 / 4;
    grid-row: 1 / 2; }
  .home-page__table {
    border: 2px solid #fbf5f4;
    text-align: center;
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden; }
    .home-page__table th,
    .home-page__table td {
      background: #fff;
      font-size: 1.5vh;
      font-family: 'Geometria';
      padding: 1.5vh 2vh; }
  .home-page__download {
    align-items: center;
    display: flex; }
  .home-page__download-shedule {
    width: 4vh;
    height: 4vh;
    margin-right: 1vh;
    border-radius: 1.6vh;
    transition: all 400ms ease; }
  .home-page__main-shedule {
    color: #f78e6a;
    font-weight: 700; }
  .home-page__contacts {
    display: flex;
    flex-direction: column;
    font-size: 14px; }
    .home-page__contacts a {
      color: #000;
      display: flex;
      align-items: center; }
  .home-page__map::before {
    content: url("../images/location.png");
    margin-right: 15px; }
  .home-page__feed::before {
    content: url("../images/feed.png");
    margin-right: 15px; }
  .home-page__contacts-text {
    font-size: 14px; }
  .home-page__map-image {
    object-fit: cover;
    overflow: hidden;
    grid-column: 1 / 3;
    grid-row: 1 / 2;
    display: flex;
    justify-content: center; }
  .home-page__contact {
    margin: 15px 0; }
  .home-page__section-3 .home-page__section-logo {
    grid-column: 3 / 4;
    grid-row: 1 / 2; }
  .home-page__section-5 .home-page__section-logo {
    grid-column: 3 / 4;
    grid-row: 1 / 2; }
  .home-page__section-1 .home-page__section-logo {
    display: flex;
    flex-direction: column;
    margin: auto; }
  .home-page__section-8 .home-page__section-image img {
    width: 350px;
    height: 400px; }
  .home-page__contacts-container {
    margin: 0 auto; }
  .home-page__map-image {
    height: 85vh; }
  .home-page__section-4 .info-header-tab {
    position: relative;
    cursor: pointer;
    margin: 10px 0;
    transition: 0.5s; }
    .home-page__section-4 .info-header-tab:hover::before {
      content: 'Trainer - ';
      position: absolute;
      left: -9vh;
      color: #f78e6a; }
    .home-page__section-4 .info-header-tab:hover {
      color: #f78e6a; }
  .home-page__section-4 .fade {
    animation-name: fade;
    animation-duration: 2.5s; }
@keyframes fade {
  from {
    opacity: 0.1; }
  to {
    opacity: 1; } }
  .home-page__section-4 .show {
    display: block; }
  .home-page__section-4 .hide {
    display: none; }
  .home-page__section-7 .info-header-tab7 {
    cursor: pointer;
    margin: 10px 0;
    transition: 0.5s;
    position: relative; }
    .home-page__section-7 .info-header-tab7:hover::before {
      content: 'Client - ';
      color: #f78e6a;
      position: absolute;
      left: -9vh; }
    .home-page__section-7 .info-header-tab7:hover {
      color: #f78e6a; }
  .home-page__section-7 .fade {
    animation-name: fade;
    animation-duration: 2.5s; }
@keyframes fade {
  from {
    opacity: 0.1; }
  to {
    opacity: 1; } }
  .home-page__section-7 .show {
    display: block; }
  .home-page__section-7 .hide {
    display: none; }
  .home-page__section-2 .info-header-tab2 {
    cursor: pointer;
    margin: 10px 0;
    transition: 0.5s; }
    .home-page__section-2 .info-header-tab2:hover::before {
      content: 'Trainer - ';
      color: #f78e6a; }
    .home-page__section-2 .info-header-tab2:hover {
      color: #f78e6a; }
  .home-page__section-2 .fade {
    animation-name: fade;
    animation-duration: 2.5s; }
@keyframes fade {
  from {
    opacity: 0.1; }
  to {
    opacity: 1; } }
  .home-page__section-2 .show {
    display: block; }
  .home-page__section-2 .hide {
    display: none; }

@media screen and (max-width: 1240px) {
  .home-page__section-2 .home-page__section-image {
    grid-column: 3 / 5; }
    .home-page__section-2 .home-page__section-image img {
      width: 200px;
      height: 450px; }
  .home-page__section-4 .home-page__section-image {
    grid-column: 3 / 5;
    margin-left: auto;
    margin-right: auto; }
    .home-page__section-4 .home-page__section-image img {
      width: 200px;
      height: 450px; }
  .home-page__logo-image {
    width: 400px;
    height: 120px; }
  .home-page__section-3 .home-page__section-logo {
    grid-column: 1 / 2;
    grid-row: 1 / 2; }
  .home-page__logo {
    top: 5%;
    left: 50%; }
  .home-page__social {
    left: 50%; }
  .home-page__section-name {
    display: none; }
  .home-page__table-content {
    overflow: auto;
    grid-column: 1 / 4; }
  .home-page__section-follow {
    justify-content: flex-start;
    margin-top: -35px; }
    .home-page__section-follow p {
      display: none; }
  .home-page__section-number {
    margin-top: auto; }
    .home-page__section-number p:first-child {
      margin-bottom: 2vh;
      font-size: 7.6vh; }
    .home-page__section-number p:last-child {
      font-size: 3.2vh; }
  .home-page__image {
    grid-column: 2 / 3;
    grid-row: 1 / 2;
    transform: scale(-1, 1);
    z-index: -1; }
  .home-page__section-image {
    grid-column: 4 / 5;
    grid-row: 1 / 2;
    transform: scale(-1, 1);
    z-index: -1;
    margin-top: auto; }
    .home-page__section-image img {
      width: 150px;
      height: 300px; }
  .home-page__section-3 .home-page__section-image {
    grid-column: 4 / 5;
    margin: auto; }
    .home-page__section-3 .home-page__section-image img {
      width: 250px;
      height: 300px; }
  .home-page__section-5 .home-page__section-image {
    margin: auto; }
    .home-page__section-5 .home-page__section-image img {
      width: 250px;
      height: 300px; }
  .home-page__section-7 .home-page__section-image img {
    width: 250px;
    height: 300px; }
  .home-page__section-8 .home-page__section-image img {
    width: 250px;
    height: 300px; }
  .home-page__section-logo {
    width: auto;
    grid-column: 1 / 4;
    grid-row: 1 / 2; }
  .home-page__text {
    width: 100%;
    font-size: 2vh; }
  .home-page__list-container {
    grid-column: 3 / 5;
    grid-row: 1 / 2;
    padding-bottom: 35vh;
    margin: auto; }
  .home-page__secondary-title {
    font-size: 26px;
    line-height: 25px; }
  .home-page__special-image {
    width: 400px;
    height: 400px; }
  .home-page__contacts-container {
    grid-column: 1 / 2;
    grid-row: 1 / 2; }
  .home-page__map-image {
    grid-column: 2 / 4;
    grid-row: 1 / 2; }
    .home-page__map-image img {
      height: 70vh; } }
@media screen and (max-width: 895px) {
  .home-page__logo {
    top: 5%;
    left: 85%; }
  .home-page__social {
    left: 40%; }
  .home-page__section-name {
    display: none; }
  .home-page__phone {
    display: none; }
  .home-page__section-follow {
    margin-top: -35px;
    justify-content: flex-end; }
    .home-page__section-follow p {
      display: none; }
  .home-page__section-number {
    margin-top: auto;
    grid-column: 1 / 5;
    margin-right: auto; }
    .home-page__section-number p:first-child {
      margin-bottom: 2vh;
      font-size: 30px; }
    .home-page__section-number p:last-child {
      font-size: 14px; }
  .home-page__image {
    transform: scale(1, 1);
    z-index: -1;
    margin: auto; }
    .home-page__image img {
      width: 150px;
      height: 250px;
      padding-top: 5px; }
  .home-page__section-1 .home-page__section-content {
    display: flex;
    flex-direction: column;
    align-items: center; }
  .home-page__section-4 .home-page__section-content {
    display: flex;
    flex-direction: column;
    align-items: center; }
  .home-page__section-2 .home-page__section-content {
    display: flex;
    flex-direction: column;
    align-items: center; }
    .home-page__section-2 .home-page__section-content .info-tabcontent2 {
      margin-top: 30vh; }
  .home-page__section-7 .home-page__section-content {
    display: flex;
    flex-direction: column;
    align-items: center; }
    .home-page__section-7 .home-page__section-content .info-tabcontent7 {
      margin-top: 15vh; }
  .home-page__section-9 .home-page__section-content {
    display: flex;
    flex-direction: column;
    align-items: center; }
  .home-page__map-image {
    padding-top: 15vh; }
    .home-page__map-image img {
      width: 300px; }
  .home-page__section-content {
    margin: 0 auto; }
  .home-page__section-logo {
    margin: auto; }
  .home-page__logo-image {
    width: 250px;
    height: 80px; }
  .home-page__section-image {
    display: none; }
  .home-page__section-4 .home-page__section-image {
    display: flex; }
    .home-page__section-4 .home-page__section-image img {
      width: 100px;
      height: 200px; }
  .home-page__list-container {
    display: none; }
  .home-page__input {
    width: 50vh; } }
@media screen and (max-width: 509px) {
  .home-page__card-container {
    display: grid;
    grid-template-columns: repeat(2, 32vh); }
  .home-page__secondary-title {
    font-size: 16px; }
  .home-page__text {
    font-size: 11px; } }

/*# sourceMappingURL=style.cs.map */
