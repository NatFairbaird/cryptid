export function drawPolygon(canvasId, centerX, centerY, numberOfSides, color, borderColor, dashedBorder) {
    var context = getAndClearCanvas(canvasId, centerX, centerY);
    actuallyDrawPolygon(context, numberOfSides, 10, color, borderColor, dashedBorder);
}

function getAndClearCanvas(canvasId, centerX, centerY) {
    var canvas = document.getElementById(canvasId);
    var context = canvas.getContext("2d");
    context.setTransform(1, 0, 0, 1, 0, 0);
    context.clearRect(0, 0, canvas.width, canvas.height);
    context.translate(centerX, centerY);

    return context;
}

function actuallyDrawPolygon(context, numberOfSides, radius, color, borderColor, dashedBorder) {
    var rotation = 2 * Math.PI / numberOfSides;

    context.fillStyle = color;
    context.strokeStyle = borderColor;
    context.setLineDash(dashedBorder == "True" ? [3, 4, 3, 4, 3, 3] : []);

    context.beginPath();
    context.moveTo(radius * Math.cos(0), radius * Math.sin(0));
    for (let i = 1; i < numberOfSides; i++) {
        context.lineTo(radius * Math.cos(rotation * i), radius * Math.sin(rotation * i));
    }

    context.closePath();

    if (borderColor) {
        context.stroke();
    }
    context.fill();
}

export function drawNestedPolygon(canvasId, centerX, centerY, numberOfSides, outerColor, outerBorderColor, dashedBorder, innerColor, innerBorderColor) {
    var context = getAndClearCanvas(canvasId, centerX, centerY);
    actuallyDrawPolygon(context, numberOfSides, 10, outerColor, outerBorderColor, dashedBorder);
    actuallyDrawPolygon(context, numberOfSides, 7, innerColor, innerBorderColor);
}