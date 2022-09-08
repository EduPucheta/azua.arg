@charset "UTF-8";
/*Este es un extend*/
.Footer__social {
  display: flex;
  justify-content: space-around;
  flex-direction: row;
}

/*Este es hace lo mismo que el extend pero con mixin*/
.draw-border {
  box-shadow: inset 0 0 0 4px white;
  color: white;
  transition: color 0.25s 0.0833333333s;
  position: relative;
}
.draw-border::before, .draw-border::after {
  border: 0 solid transparent;
  box-sizing: border-box;
  content: "";
  pointer-events: none;
  position: absolute;
  width: 0;
  height: 0;
  bottom: 0;
  right: 0;
}
.draw-border::before {
  border-bottom-width: 4px;
  border-left-width: 4px;
}
.draw-border::after {
  border-top-width: 4px;
  border-right-width: 4px;
}
.draw-border:hover {
  color: #e9c46a;
}
.draw-border:hover::before, .draw-border:hover::after {
  border-color: #e9c46a;
  transition: border-color 0s, width 0.25s, height 0.25s;
  width: 100%;
  height: 100%;
}
.draw-border:hover::before {
  transition-delay: 0s, 0s, 0.25s;
}
.draw-border:hover::after {
  transition-delay: 0s, 0.25s, 0s;
}

.btn {
  background: none;
  border: none;
  cursor: pointer;
  line-height: 1.5;
  font: 700 1.2rem "Roboto Slab", sans-serif;
  padding: 1em 2em;
  letter-spacing: 0.05rem;
}
.btn:focus {
  outline: 2px dotted #55d7dc;
}

.hero {
  box-shadow: rgba(0, 0, 0, 0.25) 0px 54px 55px, rgba(0, 0, 0, 0.12) 0px -12px 30px, rgba(0, 0, 0, 0.12) 0px 4px 6px, rgba(0, 0, 0, 0.17) 0px 12px 13px, rgba(0, 0, 0, 0.09) 0px -3px 5px;
  background-color: #264653;
  margin: 20px;
  color: white;
  text-align: center;
}
.hero h1,
.hero p {
  margin: 15px;
}
.hero h1 {
  padding-top: 30px;
}
.hero img {
  height: 250px;
  width: 250px;
}
@media (max-width: 768px) {
  .hero img {
    margin: 40px;
  }
}
@media (min-width: 768px) {
  .hero {
    height: 500px;
    display: flex;
    flex-direction: row;
    justify-content: space-evenly;
    padding: 50px;
  }
  .hero .hero__text {
    width: 800px;
  }
  .hero .hero__text h1,
.hero .hero__text p {
    margin: 40px;
  }
  .hero img {
    height: 400px;
    width: 400px;
  }
}

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
  min-height: 800px;
}
@media (min-width: 768px) {
  .form {
    min-height: 900px;
  }
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

/* Acá se forma el background*/
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

nav .nav-link2 {
  color: white;
}
nav .nav-link2:hover {
  color: #e9c46a;
  transition: 0.4s;
}
nav .bttn-color {
  background-color: #2a9d8f;
  border: none;
}
nav .bttn-color:hover {
  color: #e9c46a;
  background-color: #2a9d8f;
  transition: 0.4s;
}

.navYfooter {
  background-color: #264653;
  padding: 24px;
}

h2 {
  text-align: center;
  color: white;
}

.h2__index {
  margin-top: 60px;
}

.Productos {
  margin: 50px;
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  justify-content: space-around;
  align-items: center;
  text-align: center;
}
.Productos .Productos__child {
  box-shadow: rgba(0, 0, 0, 0.25) 0px 54px 55px, rgba(0, 0, 0, 0.12) 0px -12px 30px, rgba(0, 0, 0, 0.12) 0px 4px 6px, rgba(0, 0, 0, 0.17) 0px 12px 13px, rgba(0, 0, 0, 0.09) 0px -3px 5px;
  margin: 20px;
  width: 100%;
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

/*la idea de este css es para implementar generico a todos los botones */
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
  border: 0px;
}
.bttn:hover {
  transition: 0.4s;
  background-color: #e76f51;
}
.bttn a {
  text-decoration: none;
  border: none;
  transition: 0.4s;
  color: white;
}
.bttn a:hover {
  transition: 0.4s;
  background-color: #e76f51;
}

/* para espacear lo iconos de social (solo se usa ahi)*/
.Footer__social {
  max-width: 800px;
  margin: auto;
}

.encontrarnos {
  margin: auto;
  max-width: 800px;
  padding: 10px;
}
.encontrarnos p {
  color: white;
}
.encontrarnos iframe {
  box-shadow: rgba(0, 0, 0, 0.25) 0px 54px 55px, rgba(0, 0, 0, 0.12) 0px -12px 30px, rgba(0, 0, 0, 0.12) 0px 4px 6px, rgba(0, 0, 0, 0.17) 0px 12px 13px, rgba(0, 0, 0, 0.09) 0px -3px 5px;
}

.newsletter {
  margin: auto;
  max-width: 800px;
  padding: 10px;
}
.newsletter .carousel2 {
  box-shadow: rgba(0, 0, 0, 0.25) 0px 54px 55px, rgba(0, 0, 0, 0.12) 0px -12px 30px, rgba(0, 0, 0, 0.12) 0px 4px 6px, rgba(0, 0, 0, 0.17) 0px 12px 13px, rgba(0, 0, 0, 0.09) 0px -3px 5px;
}
.newsletter p {
  color: white;
}
.newsletter .newsletter_label {
  color: white;
}
.newsletter .bttn {
  max-width: 200px;
  border: none;
}
@media (min-width: 768px) {
  .newsletter .newsletter_suscripcion {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    margin: 10px;
  }
  .newsletter .newletter_input {
    height: 50px;
    margin-top: 10px;
  }
  .newsletter .bttn {
    height: 50px;
    margin: 10px;
  }
  .newsletter .carousel2 {
    max-width: 75%;
    margin: auto;
    box-shadow: rgba(0, 0, 0, 0.25) 0px 54px 55px, rgba(0, 0, 0, 0.12) 0px -12px 30px, rgba(0, 0, 0, 0.12) 0px 4px 6px, rgba(0, 0, 0, 0.17) 0px 12px 13px, rgba(0, 0, 0, 0.09) 0px -3px 5px;
  }
}

/*# sourceMappingURL=style.cs.map */
