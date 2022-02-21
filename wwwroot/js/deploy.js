window.onload = async function () {
    document.getElementById("selCores").style.visibility = 'hidden';
    document.getElementById("selRam").style.visibility = 'hidden';
    document.getElementById("selHdd").style.visibility = 'hidden';
    await displayTemplates();
    await displayVApps();
}

async function displayTemplates() {
    let wrapper = await loadTemplates();
    let secTemplates = document.getElementById("selTemplate");
    for (var template of wrapper.list) {
        secTemplates.innerHTML += `<option value="${template.id}">${template.name}</option> `
    }
}

//document.getElementById("btnProgress").addEventListener('click', toProgress);
function toProgress() {
    window.location.href = "/Progress";
}

async function loadTemplates() {
    let listTemplates = await fetch('/deploy/getalltemplates', {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
        },
    })
        .then(response => response.json())
        .catch(ex => console.log(ex.message));
    console.log("Templates: " + listTemplates);
    return listTemplates;
}

async function displayVApps() {
    let wrapper = await loadVApps();
    console.log("Display => list of vApps: ");
    console.log(wrapper);
    let secVApps = document.getElementById("selVapp");
    console.log(secVApps);
    for (var vapp of wrapper.list) {
        secVApps.innerHTML += `<option value="${vapp.id}">${vapp.name}</option>`
    }
}

async function loadVApps() {

    let listVApps = await fetch('/deploy/getallvapps', {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
        },
    })
        .then(response => response.json())
        .catch(ex => console.log(ex));
    console.log('Fetch => vApps: ' + listVApps);
    return listVApps;

}

document.getElementById("selTemplate").addEventListener('change', showParamsOfTemplate);

//function testFunction() {
//    console.log("testFunction was called: ");
//}

async function showParamsOfTemplate() {
    let cores = document.getElementById("selCores");
    let ram = document.getElementById("selRam");
    let hdd = document.getElementById("selHdd");
    let tempId = document.getElementById("selTemplate").value;
    let template = await loadTemplate(tempId);

    cores.value = template.cores;
    ram.value = template.ramInGb;
    hdd.value = template.hddInGb;
    cores.style.visibility = 'visible';
    ram.style.visibility = 'visible';
    hdd.style.visibility = 'visible';
}

async function loadTemplate(id) {
    let template = await fetch('/deploy/gettemplatebyid/' + id, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
        },
    })
        .then(response => response.json())
        .catch(ex => console.log(ex.message));
    console.log("selected Template: " + template);
    return template;
}

let btn_deploy = document.getElementById("deploy");

btn_deploy.addEventListener("click", clickDeploy);
async function clickDeploy() {
    let errorDiv = document.getElementById("errorDiv");
    errorDiv.innerHTML = "";
    if (await postSelection() === true) {
        //let idOfDeployment = await startDeployment();
        //startDeployment();
        //ersetzten durch Aufruf des Controllers mit ID um das zu transportieren
        let path = "/progress/42";
        console.log(path);
        setTimeout(function () { window.location.href = path; }, 1000);
        /*setTimeout(function () { window.location.href = "/progress/details/" + idOfDeployment; }, 1000);*/
    } else {
        errorDiv.innerHTML += `<h3>Fehler bei der Eingabe! Mindestens einer der eingegebenen Werte lag außerhalb des gültigen Bereichs</h3></br><h4>Die Werte dürfen nicht kleiner sein als die Standardwerte des Templates</h4>`
        document.getElementById("selCores").style.visibility = 'hidden';
        document.getElementById("selRam").style.visibility = 'hidden';
        document.getElementById("selHdd").style.visibility = 'hidden';
    }
}

async function startDeployment() {


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

async function postSelection() {

    let selection = {
        'ContainerName': document.getElementById("inName").value,
        'PcName': document.getElementById("inPcName").value,
        'Description': "",
        'vAppId': parseInt(document.getElementById("selVapp").value),
        'templateId': parseInt(document.getElementById("selTemplate").value),
        'cores': parseInt(document.getElementById("selCores").value),
        'ram': parseInt(document.getElementById("selRam").value),
        'hdd': parseInt(document.getElementById("selHdd").value)
    }

    let erg = false;
    let res = await fetch('/deploy/createvm', {
        method: 'POST',
        headers: {
            Accept: 'text / plain',
            //'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(selection),
    })
        .then(response => {
            return response.text();
        })
        //.then(response => {
        //    console.log(response);
        //    response.text();
        //    console.log(response.ok);
        //    console.log(txt);
        //    if (response.message === "ok") {
        //        console.log("erfolg");
        //        erg = true;
        //        return true;
        //    } else {
        //        console.log("schade");
        //        erg = false;
        //        return false;
        //    }
        //})
        .catch(ex => console.log(ex.message));
    console.log(erg);
    //return res;
    if (res === "ok") {
        return true;
    } else {
        return false;
    }
}

//let vmName = document.getElementById("inName").value;
//console.log("VM-Name: " + vmName);

//document.getElementById("btnTest").addEventListener("click", testJs);
//function testJs() {
//    let name = document.getElementById("inName").value;
//    console.log("Name: " + name);
//    let vApp = document.getElementById("selVapp").value;
//    console.log("vApp: " + vApp);
//    let template = document.getElementById("selTemplate").value;
//    console.log("Template: " + template);
//    let cores = document.getElementById("selCores").value;
//    let ram = document.getElementById("selRam").value;
//    let hdd = document.getElementById("selHdd").value;
//    console.log("Cores: " + cores + ", Ram: " + ram + ", Hdd: " + hdd);

//    let transfer = {
//        'vmName': name,
//        'vAppId': parseInt(vApp),
//        'templateId': parseInt(template),
//        'cores': parseInt(cores),
//        'ram': parseInt(ram),
//        'hdd': parseInt(hdd)
//    };
//    console.log(transfer);
//}