function solve(params){
    var rowsAndCols = params[0].split(' ').map(Number);
    var rows = rowsAndCols[0];
    var cols = rowsAndCols[1];
    var matrix = [];
    for (var q = 0; q < rows; q++) {
        var currentRow = '';
        for (var j = 0; j < cols - 1; j++) {
            currentRow += '-' + ' ';
        }
        currentRow += '-';
        matrix.push(currentRow.split(' '));
    }
    // console.log(matrix);
    var debrisMatrix = params[1].split(';');
    for (var p = 0; p < debrisMatrix.length; p++){
        var currentDebrisIndexes = debrisMatrix[p].split(' ').map(Number);
        //console.log(matrix);
        matrix[currentDebrisIndexes[0]][currentDebrisIndexes[1]] = 'x';
    }
    matrix[0][0] = '0';
    matrix[0][1] = '1';
    matrix[0][2] = '2';
    matrix[0][3] = '3';
    matrix[rows - 1][cols - 1] = '4';
    matrix[rows - 1][cols - 2] = '5';
    matrix[rows - 1][cols - 3] = '6';
    matrix[rows - 1][cols - 4] = '7';
    var tank0Row = 0,tank1Row = 0,tank2Row = 0,tank3Row = 0,tank4Row = rows - 1,tank5Row = rows - 1,tank6Row = rows - 1,tank7Row = rows - 1,
        tank0Col = 0,tank1Col = 1,tank2Col = 2,tank3Col = 3,tank4Col = cols - 1,tank5Col = cols - 2,tank6Col = cols - 3,tank7Col = cols - 4,
        tank0Dead = false,tank1Dead = false,tank2Dead = false,tank3Dead = false,tank4Dead = false,tank5Dead = false,tank6Dead = false,tank7Dead = false;
    for (var i = 0; i < parseInt(params[2]); i++){
        var currentLine = params[i+3].split(' ');
        if (currentLine[0] == 'mv'){
            if ((currentLine[1] == '0') && (tank0Dead == false)){
                if (currentLine[3] == 'u'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank0Row - 1 < 0){
                            // matrix[tank0Row][tank0Col] = '-';
                            // console.log('tank 0 is gg');
                            // tank0Dead = true;
                            break;
                        }
                        else if (matrix[tank0Row - 1][tank0Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank0Row - 1][tank0Col] = '0';
                            matrix[tank0Row][tank0Col] = '-';
                            tank0Row -= 1;
                        }
                    }
                }
               else if (currentLine[3] == 'l'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank0Col - 1 < 0){
                            // matrix[tank0Row][tank0Col] = '-';
                            // console.log('tank 0 is gg');
                            // tank0Dead = true;
                            break;
                        }
                        else if (matrix[tank0Row][tank0Col - 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank0Row][tank0Col - 1] = '0';
                            matrix[tank0Row][tank0Col] = '-';
                            tank0Col -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'r'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank0Col + 1 >= cols){
                            // matrix[tank0Row][tank0Col] = '-';
                            // console.log('tank 0 is gg');
                            // tank0Dead = true;
                            break;
                        }
                        else if (matrix[tank0Row][tank0Col + 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank0Row][tank0Col + 1] = '0';
                            matrix[tank0Row][tank0Col] = '-';
                            tank0Col += 1;
                        }
                    }
                }
                else if (currentLine[3] == 'd'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank0Row + 1 >= rows){
                            // matrix[tank0Row][tank0Col] = '-';
                            // console.log('tank 0 is gg');
                            // tank0Dead = true;
                            break;
                        }
                        else if (matrix[tank0Row + 1][tank0Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank0Row + 1][tank0Col] = '0';
                            matrix[tank0Row][tank0Col] = '-';
                            tank0Row += 1;
                        }
                    }
                }
            }
            else if ((currentLine[1] == '1') && (tank1Dead == false)){
                if (currentLine[3] == 'u'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank1Row - 1 < 0){
                            // matrix[tank1Row][tank1Col] = '-';
                            // console.log('tank 1 is gg');
                            // tank1Dead = true;
                            break;
                        }
                        else if (matrix[tank1Row - 1][tank1Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank1Row - 1][tank1Col] = '1';
                            matrix[tank1Row][tank1Col] = '-';
                            tank1Row -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'l'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank1Col - 1 < 0){
                            // matrix[tank1Row][tank1Col] = '-';
                            // console.log('tank 1 is gg');
                            // tank1Dead = true;
                            break;
                        }
                        else if (matrix[tank1Row][tank1Col - 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank1Row][tank1Col - 1] = '1';
                            matrix[tank1Row][tank1Col] = '-';
                            tank1Col -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'r'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank1Col + 1 >= cols){
                            // matrix[tank1Row][tank1Col] = '-';
                            // console.log('tank 1 is gg');
                            // tank1Dead = true;
                            break;
                        }
                        else if (matrix[tank1Row][tank1Col + 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank1Row][tank1Col + 1] = '1';
                            matrix[tank1Row][tank1Col] = '-';
                            tank1Col += 1;
                        }
                    }
                }
                else if (currentLine[3] == 'd'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank1Row + 1 >= rows){
                            // matrix[tank1Row][tank1Col] = '-';
                            // console.log('tank 1 is gg');
                            // tank1Dead = true;
                            break;
                        }
                        else if (matrix[tank1Row + 1][tank1Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank1Row + 1][tank1Col] = '1';
                            matrix[tank1Row][tank1Col] = '-';
                            tank1Row += 1;
                        }
                    }
                }
            }

            else if ((currentLine[1] == '2') && (tank2Dead == false)){
                if (currentLine[3] == 'u'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank2Row - 1 < 0){
                            // matrix[tank2Row][tank2Col] = '-';
                            // console.log('tank 2 is gg');
                            // tank2Dead = true;
                            break;
                        }
                        else if (matrix[tank2Row - 1][tank2Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank2Row - 1][tank2Col] = '2';
                            matrix[tank2Row][tank2Col] = '-';
                            tank2Row -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'l'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank2Col - 1 < 0){
                            // matrix[tank2Row][tank2Col] = '-';
                            // console.log('tank 2 is gg');
                            // tank2Dead = true;
                            break;
                        }
                        else if (matrix[tank2Row][tank2Col - 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank2Row][tank2Col - 1] = '2';
                            matrix[tank2Row][tank2Col] = '-';
                            tank2Col -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'r'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank2Col + 1 >= cols){
                            // matrix[tank2Row][tank2Col] = '-';
                            // console.log('tank 2 is gg');
                            // tank2Dead = true;
                            break;
                        }
                        else if (matrix[tank2Row][tank2Col + 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank2Row][tank2Col + 1] = '2';
                            matrix[tank2Row][tank2Col] = '-';
                            tank2Col += 1;
                        }
                    }
                }
                else if (currentLine[3] == 'd'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank2Row + 1 >= rows){
                            // matrix[tank2Row][tank2Col] = '-';
                            // console.log('tank 2 is gg');
                            // tank2Dead = true;
                            break;
                        }
                        else if (matrix[tank2Row + 1][tank2Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank2Row + 1][tank2Col] = '2';
                            matrix[tank2Row][tank2Col] = '-';
                            tank2Row += 1;
                        }
                    }
                }
            }

            else if ((currentLine[1] == '3') && (tank3Dead == false)){
                if (currentLine[3] == 'u'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank3Row - 1 < 0){
                            // matrix[tank3Row][tank3Col] = '-';
                            // console.log('tank 3 is gg');
                            // tank3Dead = true;
                            break;
                        }
                        else if (matrix[tank3Row - 1][tank3Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank3Row - 1][tank3Col] = '3';
                            matrix[tank3Row][tank3Col] = '-';
                            tank3Row -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'l'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank3Col - 1 < 0){
                            // matrix[tank3Row][tank3Col] = '-';
                            // console.log('tank 3 is gg');
                            // tank3Dead = true;
                            break;
                        }
                        else if (matrix[tank3Row][tank3Col - 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank3Row][tank3Col - 1] = '3';
                            matrix[tank3Row][tank3Col] = '-';
                            tank3Col -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'r'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank3Col + 1 >= cols){
                            // matrix[tank3Row][tank3Col] = '-';
                            // console.log('tank 3 is gg');
                            // tank3Dead = true;
                            break;
                        }
                        else if (matrix[tank3Row][tank3Col + 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank3Row][tank3Col + 1] = '3';
                            matrix[tank3Row][tank3Col] = '-';
                            tank3Col += 1;
                        }
                    }
                }
                else if (currentLine[3] == 'd'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank3Row + 1 >= rows){
                            // matrix[tank3Row][tank3Col] = '-';
                            // console.log('tank 3 is gg');
                            // tank3Dead = true;
                            break;
                        }
                        else if (matrix[tank3Row + 1][tank3Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank3Row + 1][tank3Col] = '3';
                            matrix[tank3Row][tank3Col] = '-';
                            tank3Row += 1;
                        }
                    }
                }
            }

            else if ((currentLine[1] == '4') && (tank4Dead == false)){
                if (currentLine[3] == 'u'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank4Row - 1 < 0){
                            // matrix[tank4Row][tank4Col] = '-';
                            // console.log('tank 4 is gg');
                            // tank4Dead = true;
                            break;
                        }
                        else if (matrix[tank4Row - 1][tank4Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank4Row - 1][tank4Col] = '4';
                            matrix[tank4Row][tank4Col] = '-';
                            tank4Row -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'l'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank4Col - 1 < 0){
                            // matrix[tank4Row][tank4Col] = '-';
                            // console.log('tank 4 is gg');
                            // tank4Dead = true;
                            break;
                        }
                        else if (matrix[tank4Row][tank4Col - 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank4Row][tank4Col - 1] = '4';
                            matrix[tank4Row][tank4Col] = '-';
                            tank4Col -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'r'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank4Col + 1 >= cols){
                            // matrix[tank4Row][tank4Col] = '-';
                            // console.log('tank 4 is gg');
                            // tank4Dead = true;
                            break;
                        }
                        else if (matrix[tank4Row][tank4Col + 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank4Row][tank4Col + 1] = '4';
                            matrix[tank4Row][tank4Col] = '-';
                            tank4Col += 1;
                        }
                    }
                }
                else if (currentLine[3] == 'd'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank4Row + 1 >= rows){
                            // matrix[tank4Row][tank4Col] = '-';
                            // console.log('tank 4 is gg');
                            // tank4Dead = true;
                            break;
                        }
                        else if (matrix[tank4Row + 1][tank4Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank4Row + 1][tank4Col] = '4';
                            matrix[tank4Row][tank4Col] = '-';
                            tank4Row += 1;
                        }
                    }
                }
            }

            else if ((currentLine[1] == '5') && (tank5Dead == false)){
                if (currentLine[3] == 'u'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank5Row - 1 < 0){
                            // matrix[tank5Row][tank5Col] = '-';
                            // console.log('tank 5 is gg');
                            // tank5Dead = true;
                            break;
                        }
                        else if (matrix[tank5Row - 1][tank5Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank5Row - 1][tank5Col] = '5';
                            matrix[tank5Row][tank5Col] = '-';
                            tank5Row -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'l'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank5Col - 1 < 0){
                            // matrix[tank5Row][tank5Col] = '-';
                            // console.log('tank 5 is gg');
                            // tank5Dead = true;
                            break;
                        }
                        else if (matrix[tank5Row][tank5Col - 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank5Row][tank5Col - 1] = '5';
                            matrix[tank5Row][tank5Col] = '-';
                            tank5Col -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'r'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank5Col + 1 >= cols){
                            // matrix[tank5Row][tank5Col] = '-';
                            // console.log('tank 5 is gg');
                            // tank5Dead = true;
                            break;
                        }
                        else if (matrix[tank5Row][tank5Col + 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank5Row][tank5Col + 1] = '5';
                            matrix[tank5Row][tank5Col] = '-';
                            tank5Col += 1;
                        }
                    }
                }
                else if (currentLine[3] == 'd'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank5Row + 1 >= rows){
                            // matrix[tank5Row][tank5Col] = '-';
                            // console.log('tank 5 is gg');
                            // tank5Dead = true;
                            break;
                        }
                        else if (matrix[tank5Row + 1][tank5Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank5Row + 1][tank5Col] = '5';
                            matrix[tank5Row][tank5Col] = '-';
                            tank5Row += 1;
                        }
                    }
                }
            }

            else if ((currentLine[1] == '6') && (tank6Dead == false)){
                if (currentLine[3] == 'u'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank6Row - 1 < 0){
                            // matrix[tank6Row][tank6Col] = '-';
                            // console.log('tank 6 is gg');
                            // tank6Dead = true;
                            break;
                        }
                        else if (matrix[tank6Row - 1][tank6Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank6Row - 1][tank6Col] = '6';
                            matrix[tank6Row][tank6Col] = '-';
                            tank6Row -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'l'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank6Col - 1 < 0){
                            // matrix[tank6Row][tank6Col] = '-';
                            // console.log('tank 6 is gg');
                            // tank6Dead = true;
                            break;
                        }
                        else if (matrix[tank6Row][tank6Col - 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank6Row][tank6Col - 1] = '6';
                            matrix[tank6Row][tank6Col] = '-';
                            tank6Col -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'r'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank6Col + 1 >= cols){
                            // matrix[tank6Row][tank6Col] = '-';
                            // console.log('tank 6 is gg');
                            // tank6Dead = true;
                            break;
                        }
                        else if (matrix[tank6Row][tank6Col + 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank6Row][tank6Col + 1] = '6';
                            matrix[tank6Row][tank6Col] = '-';
                            tank6Col += 1;
                        }
                    }
                }
                else if (currentLine[3] == 'd'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank6Row + 1 >= rows){
                            // matrix[tank6Row][tank6Col] = '-';
                            // console.log('tank 6 is gg');
                            // tank6Dead = true;
                            break;
                        }
                        else if (matrix[tank6Row + 1][tank6Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank6Row + 1][tank6Col] = '6';
                            matrix[tank6Row][tank6Col] = '-';
                            tank6Row += 1;
                        }
                    }
                }
            }

            else if ((currentLine[1] == '7') && (tank7Dead == false)){
                if (currentLine[3] == 'u'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank7Row - 1 < 0){
                            // matrix[tank7Row][tank7Col] = '-';
                            // console.log('tank 7 is gg');
                            // tank7Dead = true;
                            break;
                        }
                        else if (matrix[tank7Row - 1][tank7Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank7Row - 1][tank7Col] = '7';
                            matrix[tank7Row][tank7Col] = '-';
                            tank7Row -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'l'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank7Col - 1 < 0){
                            // matrix[tank7Row][tank7Col] = '-';
                            // console.log('tank 7 is gg');
                            // tank7Dead = true;
                            break;
                        }
                        else if (matrix[tank7Row][tank7Col - 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank7Row][tank7Col - 1] = '7';
                            matrix[tank7Row][tank7Col] = '-';
                            tank7Col -= 1;
                        }
                    }
                }
                else if (currentLine[3] == 'r'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank7Col + 1 >= cols){
                            // matrix[tank7Row][tank7Col] = '-';
                            // console.log('tank 7 is gg');
                            // tank7Dead = true;
                            break;
                        }
                        else if (matrix[tank7Row][tank7Col + 1] != '-'){
                            break;
                        }
                        else {
                            matrix[tank7Row][tank7Col + 1] = '7';
                            matrix[tank7Row][tank7Col] = '-';
                            tank7Col += 1;
                        }
                    }
                }
                else if (currentLine[3] == 'd'){
                    for (var z = 0; z < parseInt(currentLine[2]); z++){
                        if (tank7Row + 1 >= rows){
                            // matrix[tank7Row][tank7Col] = '-';
                            // console.log('tank 7 is gg');
                            // tank7Dead = true;
                            break;
                        }
                        else if (matrix[tank7Row + 1][tank7Col] != '-'){
                            break;
                        }
                        else {
                            matrix[tank7Row + 1][tank7Col] = '7';
                            matrix[tank7Row][tank7Col] = '-';
                            tank7Row += 1;
                        }
                    }
                }
            }
            if ((tank0Dead == true)&& (tank1Dead == true)&& (tank2Dead == true)&& (tank3Dead == true)){
                console.log('Koceto is gg');
                break;
            }
            if ((tank4Dead == true)&& (tank5Dead == true)&& (tank6Dead == true)&& (tank7Dead == true)){
                console.log('Cuki is gg');
                break;
            }
        }
        else {
            var shotRow = 0;
            var shotCol = 0;
            if ((currentLine[1] == '0')&&(tank0Dead == false)){
                shotRow = tank0Row;
                shotCol = tank0Col;
            }
            else if ((currentLine[1] == '1')&&(tank1Dead == false)){
                shotRow = tank1Row;
                shotCol = tank1Col;
            }
            else if ((currentLine[1] == '2')&&(tank2Dead == false)){
                shotRow = tank2Row;
                shotCol = tank2Col;
            }
            else if ((currentLine[1] == '3')&&(tank3Dead == false)){
                shotRow = tank3Row;
                shotCol = tank3Col;
            }
            else if ((currentLine[1] == '4')&&(tank4Dead == false)){
                shotRow = tank4Row;
                shotCol = tank4Col;
            }
            else if ((currentLine[1] == '5')&&(tank5Dead == false)){
                shotRow = tank5Row;
                shotCol = tank5Col;
            }
            else if ((currentLine[1] == '6')&&(tank6Dead == false)){
                shotRow = tank6Row;
                shotCol = tank6Col;
            }
            else if ((currentLine[1] == '7')&&(tank7Dead == false)){
                shotRow = tank7Row;
                shotCol = tank7Col;
            }
            if (currentLine[2] == 'd') {
                shotRow += 1;
            }
            else if (currentLine[2] == 'u') {
                shotRow -= 1;
            }
            else if (currentLine[2] == 'r') {
                shotCol += 1;
            }
            else if (currentLine[2] == 'l') {
                shotCol -= 1;
            }
            while (true){
                            if ((shotRow >= rows)||(shotRow < 0)||(shotCol >= cols)||(shotCol < 0)){
                                    break;
                            }
                            if (matrix[shotRow][shotCol]  == '0'){
                                matrix[shotRow][shotCol] = '-';
                                tank0Dead = true;
                                console.log('Tank 0 is gg');
                                break;
                            }
                            else if (matrix[shotRow][shotCol]  == '1'){
                                matrix[shotRow][shotCol] = '-';
                                tank1Dead = true;
                                console.log('Tank 1 is gg');
                                break;
                            }
                            else if (matrix[shotRow][shotCol]  == '2'){
                                matrix[shotRow][shotCol] = '-';
                                tank2Dead = true;
                                console.log('Tank 2 is gg');
                                break;
                            }
                            else if (matrix[shotRow][shotCol]  == '3'){
                                matrix[shotRow][shotCol] = '-';
                                tank3Dead = true;
                                console.log('Tank 3 is gg');
                                break;
                            }
                            else if (matrix[shotRow][shotCol]  == '4'){
                                matrix[shotRow][shotCol] = '-';
                                tank4Dead = true;
                                console.log('Tank 4 is gg');
                                break;
                            }
                            else if (matrix[shotRow][shotCol]  == '5'){
                                matrix[shotRow][shotCol] = '-';
                                tank5Dead = true;
                                console.log('Tank 5 is gg');
                                break;
                            }
                            else if (matrix[shotRow][shotCol]  == '6'){
                                matrix[shotRow][shotCol] = '-';
                                tank6Dead = true;
                                console.log('Tank 6 is gg');
                                break;
                            }
                            else if (matrix[shotRow][shotCol]  == '7'){
                                matrix[shotRow][shotCol] = '-';
                                tank7Dead = true;
                                console.log('Tank 7 is gg');
                                break;
                            }
                            else if (matrix[shotRow][shotCol] == 'x'){
                                matrix[shotRow][shotCol] = '-';
                                break;
                            }
                if (currentLine[2] == 'd') {
                    shotRow += 1;
                }
                else if (currentLine[2] == 'u') {
                    shotRow -= 1;
                }
                else if (currentLine[2] == 'r') {
                    shotCol += 1;
                }
                else if (currentLine[2] == 'l') {
                    shotCol -= 1;
                }
                        }
            if ((tank0Dead == true)&& (tank1Dead == true)&& (tank2Dead == true)&& (tank3Dead == true)){
                console.log('Koceto is gg');
                break;
            }
            if ((tank4Dead == true)&& (tank5Dead == true)&& (tank6Dead == true)&& (tank7Dead == true)){
                console.log('Cuki is gg');
                break;
            }
        }
        // console.log(matrix);
        // console.log('       ');
    }
    // console.log(matrix);
}

// var test1 = [
//     '5 5',
//     '2 0;2 1;2 2;2 3;2 4',
//     '13',
//     'mv 7 2 l',
//     'x 7 u',
//     'x 0 d',
//     'x 6 u',
//     'x 5 u',
//     'x 2 d',
//     'x 3 d',
//     'mv 4 1 u',
//     'mv 4 4 l',
//     'mv 1 1 l',
//     'x 4 u',
//     'mv 4 2 r',
//     'x 2 d'
// ];
//
// var test2 = [
//     '10 10',
//     '1 0;1 1;1 2;1 3;1 4;4 1;4 2;4 3;4 4',
//     '8',
//     'mv 4 9 u',
//     'x 4 l',
//     'x 4 l',
//     'x 4 l',
//     'x 0 r',
//     'mv 0 9 r',
//     'mv 5 1 r',
//     'x 5 u'
// ];
// var test3  = [
//     '10 5',
//     '1 0;1 1;1 2;1 3;1 4;3 1;3 3;4 0;4 2;4 4',
//     '43',
//     'mv 6 5 r',
//     'mv 0 6 d',
//     'x 0 d',
//     'x 0 d',
//     'x 6 u',
//     'x 6 u',
//     'x 6 u',
//     'x 6 u',
//     'x 6 u',
//     'x 7 u',
//     'x 7 u',
//     'x 7 u',
//     'x 7 u',
//     'x 7 u',
//     'x 3 d',
//     'x 3 d',
//     'x 3 d',
//     'x 3 d',
//     'x 3 d',
//     'x 4 u',
//     'x 4 u',
//     'x 4 u',
//     'x 4 u',
//     'x 4 u',
//     'x 0 r',
//     'mv 0 6 d',
//     'mv 0 9 r',
//     'x 0 d',
//     'mv 0 1 l',
//     'x 0 d',
//     'mv 0 1 l',
//     'x 0 d',
//     'mv 0 1 l',
//     'x 0 d',
//     'mv 0 1 l',
//     'x 0 d',
//     'mv 0 1 l',
//     'x 0 d',
//     'mv 0 1 l',
//     'x 0 d',
//     'mv 0 1 l',
//     'x 0 d',
//     'mv 0 1 l',
//     'x 0 d'
// ];
// solve(test1);
// solve(test2);
// solve(test3);