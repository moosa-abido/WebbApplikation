'use strict';
const app =
{
    roversDiv: document.getElementById('roversDiv'),
    home: document.getElementById('home'),
    btn1: document.getElementById('btn1'),
    btn2: document.getElementById('btn2'),
    btn3: document.getElementById('btn3'),
    buttons: [btn1, btn2, btn3]
}

getRovers();

app.home.addEventListener('click', function () {
    app.roversDiv.innerHTML = `<h2>Welcom!</h2>
        <h3>Contact us:<br /><br />Mail: UddeboNaturalHistory@gmail.com<br />Telephone: 0223-453785</h3>`;

})

function getRovers() {
    fetch('api/Rovers')
        .then(resp => resp.json())
        
        .then(data => displayRovers(data))
        .catch(error => console.error('Unabel to get item.', error));
}

function displayRovers(data) {

    for (var i = 0; i < data.length; i++) {
        let rover = data[i];
        let name = rover.name;
        let id = rover.id;
        let btn = app.buttons[i];
        btn.innerHTML = name;
        btn.id = id;
        btn.addEventListener('click', function () {
        
            getRoverById(id);
        })
    }
}

function getRoverById(id) {
    fetch('api/Rovers/' + id)
        .then(resp => resp.json())
        
        .then(data => displayHistory(data))
        .catch(error => console.error('Unabel to get item.', error));
}

function displayHistory(data) {
    app.roversDiv.innerHTML = '';
    app.roversDiv.innerHTML = `<div id="photoDiv"><img src="Images/` + data.name + `.jpg"/></div><div id="historyDiv"><p>` + data.history + `</p></div><button id="photoBtn">Foto</button>`;
    const photoBtn = document.getElementById('photoBtn');
    photoBtn.addEventListener('click', function () {
        getPhotos(data.name, data.id);
    })
}

function getPhotos(name, id) {
    fetch('https://api.nasa.gov/mars-photos/api/v1/rovers/' + name + '/photos?sol=739&page=' + id + '&api_key=jOIiBALTUoGtbjU06Vf7rPFELzh6pyMAeg3auAJt')
        .then(resp => resp.json())
        .then(data => displayPhotos(data))
        .catch(error => console.error('Unabel to get item.', error));
}

function displayPhotos(data) {
    app.roversDiv.innerHTML = '';
    for (var i = 0; i < data.photos.length; i++) {

        let objectURL = data.photos[i].img_src;

        let myImage = document.createElement('img');
        myImage.src = objectURL;
        app.roversDiv.insertAdjacentElement('afterbegin', myImage)
    }
}