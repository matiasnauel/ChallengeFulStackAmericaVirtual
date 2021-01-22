

jQuery(document).ready(function ($) {



    $('#txtUsuario').focus();

    if (localStorage.getItem("UserName") != undefined && localStorage.getItem("Password") != undefined) {
        $('#exampleFormControlSelect1').removeAttr('disabled');
        $('#exampleFormControlSelect2').removeAttr('disabled');
       
        ViewInformation();
    }
    else {

      

        $('#btnEntrar').on('click', function () {

            if ($('#txtUsuario').val() != "" & $('#txtClave').val() != "") {
              
                Validate($('#txtUsuario').val(), $('#txtClave').val());
                ViewInformation();

            }
            else {
                Swal.fire(
                    'Error',
                    'Favor de ingresar Usuario y Clave',
                    'error'
                )
            }
        });
    }

  

    function Validate(UserName, Password) {
        var record = {
            NameUser: UserName,
            password: Password
        };

        $.ajax({
            url: '/User/GetUser',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function (xhr, opts) {

            },
            complete: function () {

            },
            success: function (data) {
                if (data.status == true) {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'has been successfully registered',
                        showConfirmButton: false,
                        timer: 1500
                    })
                    localStorage.setItem("UserName", UserName);
                    localStorage.setItem("Password", Password);
                    //remove disable select
                    $('#exampleFormControlSelect1').removeAttr('disabled');
                    $('#exampleFormControlSelect2').removeAttr('disabled');
                  

               
                }
                else if (data.status == false) {
                    Swal.fire(
                        'Error',
                        data.message,
                        'error'
                    )
                  
                }
            },
            error: function (data) {
                Swal.fire(
                    'Error',
                    data.message,
                    'error'
                )
              
            }

        });
    }
 
    function ViewInformation() {
        const User = localStorage.getItem("UserName");
        const Password = localStorage.getItem("Password");
        url = "https://restcountries.eu/rest/v2/all";
        if (User != undefined && Password != undefined) {
            fetch(url)
                .then(data => data.json())
                .then(data => {
                
                    renderSelectCountries(data)
                })
        }
    }
    function renderSelectCountries(data) {
        const selectCountries = document.getElementById("exampleFormControlSelect1");
        selectCountries.innerHTML = "<option>Seleccioná un pais</option>";
        const resp = data.map(info => { selectCountries.innerHTML += `<option value=${info.name}>${info.name}</option>`; })
        return resp
        
    }
    $('#exampleFormControlSelect1').change(function () {

        const select = document.getElementById("exampleFormControlSelect1").value;
        const selectCountries = document.getElementById("exampleFormControlSelect2");
        const objeto = {
            "country": select
        }
        url = "https://countriesnow.space/api/v0.1/countries/states";
        $.ajax({
            type: "POST",
            url: url,
            data: objeto,
            success: function (data) {
                const resp = data.data.states.map(info => { selectCountries.innerHTML += `<option value=${info.name}>${info.name}</option>`; });
                return resp;
            }
        });

    });
    var app = {}
    $("#Search").click(function () {
        const select = document.getElementById("exampleFormControlSelect1").value;

        app.url = `https://api.openweathermap.org/data/2.5/forecast?q=${select}&lang=es&appid=b329122e8d5dbbeefad2af30cc4e43d6`
        $.ajax({
            url: app.url,
            success: function (date) {
                app.Date = date;
                app.condicionNombre = date.list[0].weather[0].main;

                app.temperatura = date.list[0].main.temp;
                var condicionIcono = date.list[0].weather[0].icon;
                app.icono = app.obtenIcono(condicionIcono);
                app.city = date.city.name;
                app.country = date.city.country;
                app.humidty = date.list[0].main.humidity;
                app.wind = date.list[0].wind.speed;

                app.description = date.list[0].weather[0].description;
                app.muestra();
            },
            error: function (data) {
                Swal.fire(
                    'Error',
                    data.message,
                    'error'
                )
            }

        })
        
    })
    //If the user did not register, they will only be able to see information from Buenos Aires Argentina
    app.cargaDatos = function () {

        app.url = `https://api.openweathermap.org/data/2.5/forecast?q=Buenos Aires&&cnt=5&lang=es&appid=b329122e8d5dbbeefad2af30cc4e43d6`
        $.ajax({
            url: app.url,
            success: function (date) {
                app.Date = date;
                app.condicionNombre = date.list[0].weather[0].main;

                app.temperatura = date.list[0].main.temp;
                var condicionIcono = date.list[0].weather[0].icon;
                app.icono = app.obtenIcono(condicionIcono);
                app.city = date.city.name;
                app.country = date.city.country;
                app.humidty = date.list[0].main.humidity;
                app.wind = date.list[0].wind.speed;
              
                app.description = date.list[0].weather[0].description;
                app.muestra(date);
            },
            error: function (data) {
                Swal.fire(
                    'Error',
                    data.message,
                    'error'
                )
            }

        })
    }
    //the function is called so that when the page loads, it automatically executes the end point
    app.cargaDatos();

    app.muestra = function (date) {
        document.getElementById("country").innerHTML = app.country;
        document.getElementById("province").innerHTML = app.city;
        document.getElementById("wind").innerHTML = app.wind;
        document.getElementById("humidity").innerHTML = app.humidty;
        document.getElementById("sky").innerHTML = (app.description).toUpperCase();
        //Kelvin to Celsius
        var valNum = app.temperatura;
        valNum = parseFloat(valNum);
        document.getElementById("temperature").innerHTML = Math.round(valNum - 273.15);
        //Kelvin to Fahrenheit
        var valNum2 = app.temperatura;
        valNum2 = parseFloat(valNum2);
        var dateDay = new Date();
        var Day = [
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"
        ]
        const numeroDia = (dateDay.getDay() - 1);
        const nombreDia = Day[numeroDia];
        document.getElementById("day").innerHTML = (nombreDia).toUpperCase();
        document.getElementById("sky").innerHTML = (app.description).toUpperCase();
        document.getElementById("Fahrenheit").innerHTML = Math.round(((valNum2 - 273.15) * 1.8) + 32);
        const srcImg = document.getElementById("imag-main");
        srcImg.src = app.icono;
        const ListCard = document.getElementById("listCard");
        const resultado = date.list.map(info => {
            const tempCelsius = Math.round(info.main.temp  - 273.15);
            const tempFahrenheit = Math.round(((info.main.temp - 273.15) * 1.8) + 32);
            var condicionIconoNew = info.weather[0].icon;
            app.iconoNew = app.obtenIcono(condicionIconoNew);
            ListCard.innerHTML+= `
                  <div class="card border-top-0 border-bottom-0 border-left-0 px-4">
                    <div class="text-center">
                        <h5 class="card-title">${nombreDia}</h5>
                    </div>


                    <img class="card-img-top" src="${app.iconoNew}" alt="Card image cap">
                    <div class="card-body">
                        <div class="d-flex flex-column text-center">
                            <span>${tempCelsius}°C</span>
                            <span>${tempFahrenheit}°</span>
                        </div>

                    </div>
                </div>
            `;
          

        })
        return resultado;
    };
    app.obtenIcono = function (weatherIcon) {
        var icon;
   
        switch (weatherIcon) {
            case "01d":
                icon = "http://openweathermap.org/img/wn/01d@2x.png";
                break;
            case "01n":
                icon = "http://openweathermap.org/img/wn/01n@2x.png";
                break;
            case "02d":
                icon = "http://openweathermap.org/img/wn/02d@2x.png"
                break;
            case "02n":
                icon = "http://openweathermap.org/img/wn/02n@2x.png";
                break;

            case "03d":
                icon = "http://openweathermap.org/img/wn/03d@2x.png";
                break;
            case "03n":
                icon = "http://openweathermap.org/img/wn/03n@2x.png";
                break;

            case "04d":
                icon = "http://openweathermap.org/img/wn/04d@2x.png";
                break;
            case "04n":
                icon = "http://openweathermap.org/img/wn/04n@2x.png";
                break;

            case "09d":
                icon = "http://openweathermap.org/img/wn/10d@2x.png";
                break;
            case "09n":
                icon = "http://openweathermap.org/img/wn/10n@2x.png";
                break;

            case "10d":
                icon = "http://openweathermap.org/img/wn/11d@2x.png";
                break;
            case "10n":
                icon = "http://openweathermap.org/img/wn/11n@2x.png";
                break;

            case "11d":
                icon = "http://openweathermap.org/img/wn/12d@2x.png";
                break;
            case "11n":
                icon = icon = "http://openweathermap.org/img/wn/12n@2x.png";
                break;

            case "13d":
                icon = "http://openweathermap.org/img/wn/13d@2x.png";
                break;
            case "13n":
                icon = "http://openweathermap.org/img/wn/13n@2x.png";
                break;

            case "50d":
                icon = "http://openweathermap.org/img/wn/14d@2x.png";
                break;
            case "50n":
                icon = "http://openweathermap.org/img/wn/14n@2x.png";
                break;

            default:
                icon = "http://openweathermap.org/img/wn/01d@2x.png";
                break;
        }

        return icon;
    };


    

   
});




