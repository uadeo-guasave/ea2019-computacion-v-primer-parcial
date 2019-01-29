// Funcionalidad
function validateLogin(e) {
    // TODO: detener la accion de submit
    e.preventDefault();
    // console.log("he pasado por aqui");
    // TODO: recoger los valores de las cajas de entrada
    let usuario = document.getElementById("txtUsuario");
    // let usuario = document.querySelector("#txtUsuario");
    let contraseña = document.getElementById("txtContrasena");
    console.log(`usuario ${usuario.value} contraseña ${contraseña.value}`);

    if (usuario.value == '') {
        // entonces el campo usuario esta vacío
        console.error(`Error: el campo ${usuario.name} es obligatorio`);
        usuario.className = 'form-control-error';
    } else {
        usuario.className = 'form-control-success';
    }
    
    if (contraseña.value == '') {
        // entonces el campo contraseña esta vacio
        console.error(`Error: el campo ${contraseña.name} es obligatorio`);
        contraseña.className = 'form-control-error';
    } else {
        contraseña.className = 'form-control-success';
    }
}

document.querySelector("#login-form>form>button[type=submit]").addEventListener("click", validateLogin);

// DOM: Document Object Model