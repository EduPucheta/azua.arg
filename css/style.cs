/*Este es un extend*/
.Footer__social {
  display: flex;
  justify-content: space-around;
  flex-direction: row;
}

/*Este es hace lo mismo que el extend pero con mixin*/
/* Este es un mapa para los botones*/
.hero__container {
  background-color: none;
  color: none;
}

.hero__imagen__contenedor {
  border: none;
  padding: 60px;
}

.hero__imagen {
  width: 350px;
  height: 350px;
}

.form {
  max-width: 500px;
  margin: 2rem auto;
  padding: 2rem;
  border-radius: 5px;
}

.form__label {
  color: white;
  font-weight: bolder;
  display: block;
  padding: 1rem 0 0.25rem;
  font-size: 14px;
}

input,
textarea,
select {
  display: block;
  width: 100%;
  border: 2px solid #343050;
  padding: 0.5rem;
  font-size: 18px;
  border-radius: 5px;
  transition: 0.4s ease;
}

legend {
  color: white;
}

/* 
npm init
sass --watch scss/style.scss css/style.css 
*/
* {
  margin: 0;
  padding: 0;
}

body {
  font-weight: normal;
  font-style: normal;
  font-family: system-ui, -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen, Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
  background-color: #4158d0;
  background-image: linear-gradient(43deg, #4158d0 0%, #c850c0 46%, #ffcc70 100%);
}

.dark-color {
  background-color: #264653;
}

.nav-link2 {
  color: white;
}
.nav-link2:hover {
  color: #e9c46a;
  transition: 0.4s;
}

.bttn-color {
  background-color: #2a9d8f;
  border: none;
}
.bttn-color:hover {
  color: #e9c46a;
  background-color: #2a9d8f;
  transition: 0.4s;
}

.navYfooter {
  background-color: #264653;
  padding: 24px;
}

.container,
.my-5 {
  background-color: rgb(241, 241, 241);
}
.container div,
.my-5 div {
  color: black;
}

h1,
.subtitulo {
  color: black;
}

h2 {
  text-align: center;
  color: white;
}

.Productos {
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  justify-content: space-around;
  align-items: center;
  text-align: center;
}
.Productos .Productos__child {
  margin: 20px;
  width: 100%;
}
.Productos p {
  text-align: center;
}

.Contacto {
  margin: 10px;
  width: 80%;
  margin-left: auto;
  margin-right: auto;
  max-width: 850px;
}
.Contacto iframe {
  width: 100%;
}

.contenidoIndex {
  margin-left: auto;
  margin-right: auto;
  width: 50%;
  height: 300px;
}

.cards__bajada {
  margin-left: auto;
  margin-right: auto;
  border: solid 1px white;
  padding: 5px;
  width: 370px;
  height: 92px;
  overflow: hidden;
}

/*la idea de este css es para implementar generico a todos los botones*/
.bttn {
  display: block;
  background: #2a9d8f;
  width: 75%;
  color: white;
  padding: 0.5rem;
  margin: 10px auto auto auto;
  cursor: pointer;
  transition: 0.4s;
  text-decoration: none;
  text-align: center;
  border-radius: 5px;
}
.bttnhover {
  background: #e74c3c;
}

/*La siguiente media query es para que la grilla solo se aplique en desktop
  y para que se muestren los elementos en una sola columna en mobile*/
@media screen and (min-width: 768px) {
  .grilla {
    display: grid;
    grid-template-columns: 1fr 1fr 1fr;
    grid-template-rows: 60px 25px 40px;
    grid-row-gap: 15px;
    grid-template-areas: "Footer__social Footer__social Footer__social" "newsletter_label newsletter_label button__newsletter" "newletter_input newletter_input button__newsletter";
  }
  .grilla .newletter_label {
    grid-area: newsletter_label;
  }
  .grilla .newletter_input {
    grid-area: newletter_input;
  }
  .grilla .button__newsletter {
    grid-area: button__newsletter;
  }
  .grilla .Footer__social {
    grid-area: Footer__social;
  }
}
/* para espacear lo iconos de social (solo se usa ahi)*/
.navYfooter .newsletter_label {
  color: white;
}
.navYfooter .button__newsletter {
  font-size: medium;
  margin-top: 40px;
}

/*# sourceMappingURL=style.cs.map */
