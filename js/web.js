function validarForm(){
    var nombre  = document.getElementById("nombre").value
    var apellido = document.getElementById("apellido").value   

    if(nombre == "")
    {
        alert("Falta Ingresar Nombre");
        return false;
    }
    else if(apellido == "")
    {
        alert("Falta Ingresar Apellido");
        return false;
    }
    else {
        alert("Formulario enviado. Muchas Gracias !!!");        
        return true;
    }
 
}

btnClear.addEventListener('click',() =>{
    inputs.forEach(input => input.value = '')
})



