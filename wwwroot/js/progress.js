window.onload = function () {
    let tableDone = document.getElementById("tableDone");
    console.log(tableDone);
   // tableDone.style.visibility = 'none';
    startTest();
}

let step1 = document.getElementById("step1");
let step2 = document.getElementById("step2");
let step3 = document.getElementById("step3");
let step1h3 = document.getElementById("step1h3");
//let done = document.getElementById("done");
//document.getElementById("btn_test").addEventListener('click', startTest);

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}

async function startTest() {
    step1.style.backgroundColor = 'antiquewhite'
    step2.style.backgroundColor = 'antiquewhite'
    step3.style.backgroundColor = 'antiquewhite'
    //done.style.backgroundColor = 'antiquewhite'
    document.getElementById("result").innerHTML = ``;
    var idst = startProgress();
    var myVar = setInterval(checkProgress, 2500);
}

async function startProgress() {
        let id = parseInt(await fetch('/deploy/start', {
            method: 'GET',
            headers: {
                'Accept': 'text/plain',
            },
        })
            .then(response => response.text())
            .catch(ex => console.log(ex.message)));
        console.log(id);
        return id;
}

async function checkProgress() {
    let id = 0;
    let status = await fetch(`/deploy/check/`, {
        method: 'GET',
        headers: {
            'Accept': 'text/plain'
        }
    })
        .then(response => {
            return response.text();
        })
        //.then(text => {
        //    console.log("data: " + text);
        //    return text;
        //})
        .catch(ex =>
            console.log(ex.message));
    console.log("status: " + status);




    //let res = await fetch('/deploy/createvm', {
    //    method: 'POST',
    //    headers: {
    //        Accept: 'text / plain',
    //        //'Accept': 'application/json, text/plain, */*',
    //        'Content-Type': 'application/json',
    //    },
    //    body: JSON.stringify(selection),
    //})
    //    .then(response => {
    //        return response.text();
    //    })

    //    .catch(ex => console.log(ex.message));
    //console.log(erg);
    ////return res;
    //if (res === "ok") {
    //    return true;
    //} else {
    //    return false;
    //}


    if (status == "") {
        step1.style.backgroundColor = 'blue';
        step1h3.innerHTML = "-6%"
    }

    if (status == "basic1") {
        step1.style.backgroundColor = 'green';
        step1h3.innerHTML="33%"
    }
    if (status == "basic2") {
        step1.style.backgroundColor = 'lightgreen';
        step1h3.innerHTML = "63%"
    }
    if (status == "basic3") {
        step3.style.backgroundColor = 'green';
    }
    if (status == "finished") {
        done.style.backgroundColor = 'green';
    }

    //int delay;
    //Random rn = new Random();
    //delay = rn.Next(2000, 5000);
    //DeployStatus = "basic1";
    //await Task.Delay(delay);
    //delay = rn.Next(3000, 5000);
    //DeployStatus = "basic2";
    //await Task.Delay(delay);
    //delay = rn.Next(4000, 7000);
    //DeployStatus = "basic3";
    //await Task.Delay(delay);
    //DeployStatus = "rec1";
    //await Task.Delay(delay);
    //DeployStatus = "rec2";
    //await Task.Delay(delay);
    //DeployStatus = "meta1";
    //await Task.Delay(delay);
    //DeployStatus = "done";


}