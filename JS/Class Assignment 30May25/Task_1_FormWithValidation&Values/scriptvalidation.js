function changeFormat(n) {
    if (n == 1) {
        document.getElementById("style").href = "Format1.css";
    } else if (n == 2) {
        document.getElementById("style").href = "Format2.css";
    } else if (n == 3) {
        document.getElementById("style").href = "Format3.css";
    }
}

function showData(event) {
    event.preventDefault();

    const form = document.forms['contactusForm'];
    const outputDiv = document.getElementById("output");

    const id = form['idTxt'].value;
    const fname = form['fnameTxt'].value;
    const lname = form['lnameTxt'].value;
    const dept = form['deptTxt'].value;
    const sdate = form['sdateTxt'].value;
    const salary = form['salaryTxt'].value;
    const gender = form['gender'].value;
    const query = form['queryTxt'].value;
    const pwd = form['pwd'].value;
    const cpwd = form['cpwd'].value;
    const cars = form['cars'].value;

    if (pwd !== cpwd) {
        alert("Passwords do not match!");
        return false;
    }

    const fields = Array.from(document.querySelectorAll('input[name="field"]:checked'))
                        .map(cb => cb.value)
                        .join(", ");

    outputDiv.innerHTML = `
        <h3>Submitted Details:</h3>
        <strong>Emp ID:</strong> ${id}<br>
        <strong>Name:</strong> ${fname} ${lname}<br>
        <strong>Dept No:</strong> ${dept}<br>
        <strong>Start Date:</strong> ${sdate}<br>
        <strong>Salary:</strong> ₹${salary}<br>
        <strong>Gender:</strong> ${gender}<br>
        <strong>Field:</strong> ${fields}<br>
        <strong>Comment:</strong> ${query}<br>
        <strong>Car Chosen:</strong> ${cars}<br>
    `;

    return true;
}
