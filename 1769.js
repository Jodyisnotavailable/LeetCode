/**
 * @param {string} boxes
 * @return {number[]}
 */
var minOperations = function(boxes) {
    const res = (new Array(boxes.length)).fill(0);
    
    //from left to right
    let ballsL = 0, movesL = 0;
    for (let i = 0; i < boxes.length; i ++) {
        res[i] = ballsL + movesL;
        movesL = res[i];
        if (boxes[i] == 1) {
            ballsL ++;
        }
    }

    //from right to left
    let ballsR = 0, movesR = 0;
    let sum = 0; //cannot directly use res[] to update moves bc it already has values from above loop
    for (let j = boxes.length-1; j >=0; j --) {
        sum = ballsR + movesR;
        res[j] += sum;
        movesR = sum;
        if (boxes[j] == 1) {
            ballsR ++;
        }
    }

    return res;
};
