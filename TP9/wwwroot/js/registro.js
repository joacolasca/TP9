function CumpleCondiciones()
{
    let campoContraseña = document.getElementById('Contraseña').value;
    let campoContraseña2 = document.getElementById('Contraseña2').value;

    if (campoContraseña == campoContraseña2) 
    {
        if(campoContraseña.length > 8)
        {
            const caracterEspecialRegex = /[!@#$%^&*()_+{}\[\]:;<>,.?~\\]/;
            if(caracterEspecialRegex.test(campoContraseña))
            {
                const letraMayusculaRegex = /[A-Z]/;
                if (letraMayusculaRegex.test(campoContraseña)) 
                {
                    return true;
                }
            }
        }
    }
    let Parrafo = document.getElementById('error')
    Parrafo.innerHTML = "La contraseña no cumple con los requisitos"
    return false;
}
 


