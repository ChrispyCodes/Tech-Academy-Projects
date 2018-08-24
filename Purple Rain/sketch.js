// Purple Rain
// (138, 43, 226)
// (230, 230, 250) // background

var drops = [100];

function setup() {
  createCanvas(1500, 900);
  for (var i = 0; i < 500; i++) {
    drops[i] = new Drop();
  }
}

function draw() {
  background(230, 230, 250);
  for (var i = 0; i < drops.length; i++){
    drops[i].fall();
    drops[i].show();
  }
}
