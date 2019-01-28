// Funcionalidad
function validateLogin(e) {
    // TODO: detener la accion de submit
    e.preventDefault();
    console.log("he pasado por aqui");
    // TODO: recoger los valores de las cajas de entrada
    let usuario = document.getElementById("txtUsuario").value;
    // let usuario = document.querySelector("#txtUsuario");
    let contraseña = document.getElementById("txtContrasena").value;
    console.log(`usuario ${usuario} contraseña ${contraseña}`);
}

document.querySelector("#login-form>form>button[type=submit]").addEventListener("click", validateLogin);