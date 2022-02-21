window.onload = function () {
    document.getElementById("help").style.visibility = 'hidden';
}

//document.getElementById("btn_help").addEventListener("click", clickHelp);

//function clickHelp() {
//    document.getElementById("help").style.visibility = 'visible';
//}

document.getElementById("btn_login").addEventListener("click", login);

//async function clickLogin() {
//    let res = await login();
//    console.log("Result of method login(): ")
//    console.log(res);
//}

async function login() {
    setTimeout(function () { window.location.href = "/deploy";}, 500);
}

