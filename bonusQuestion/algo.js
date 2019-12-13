// To find sum of digits in array
function summation(arr){
    var value =0;
    for(i=0; i<arr.length;i++){
        value = value + arr[i];
    }
    return value;
}


var evenDigitArr=[];
var oddDigitArr=[];
// Generating 20 numbers and storing the odd-even difference in evenDiigitArr if No. of digits even else in oddDigitArr
for(i=0;i<20; i++){
    var oddDifEven =0;
    var noOfDigits = Math.floor((Math.random() * 10)+1);
    for(j=0; j<noOfDigits; j++){
        var x = Math.floor((Math.random() *10));
        if(j%2==0){
            oddDifEven = oddDifEven + x;
        }
        else{
            oddDifEven= oddDifEven -x;
        }
    }
    if(noOfDigits%2==0){
        evenDigitArr.push(oddDifEven);
    }
    else{
        oddDigitArr.push(oddDifEven);
    }
}

var sumOddDigitArr =summation(oddDigitArr);

// Setting Up Combinations of Odd  digit number and returning their sum : (Length of OddDigitArr)C(Length of OddDigitArr/2) cases
function k_combinations(set, k) {
    var i, j, combs, head, tailcombs;
    if (k > set.length || k <= 0) {
        return [];
    }

    if (k == set.length) {
        return [set];
    }

    if (k == 1) {
        combs = [];
        for (i = 0; i < set.length; i++) {
            combs.push([set[i]]);
        }
        return combs;
    }
    combs = [];

    for (i = 0; i < set.length - k + 1; i++) {
        head = set.slice(i, i + 1);
        tailcombs = k_combinations(set.slice(i + 1), k - 1);
        for (j = 0; j < tailcombs.length; j++) {
            combs.push(head.concat(tailcombs[j]));
        }

    }
    sumcombs=[];
    for( i=0; i<combs.length; i++){
        sumOfCombinatios= summation(combs[i]);
        sumcombs.push(sumOfCombinatios);
    }
    return sumcombs;
}

sumOddComb = k_combinations(oddDigitArr,Math.floor(oddDigitArr.length/2));

//Setting up different up even combination and returning the sum 2^(Number in eveb digit array) cases possible
var sumEvenComb=[];
for(i=0; i<Math.pow(2,evenDigitArr.length); i++){
    var x = i.toString(2);
    var sumeven=0;
    for( j =0; j<evenDigitArr.length; j++){
        var y = x & j.toString(2);
        if(y){
            sumeven= sumeven-evenDigitArr[j];
        }
        else {
            sumeven= sumeven +evenDigitArr[j];
        }
    }
    sumEvenComb.push(sumeven);
}

var absmin;
var absval;
var val;
for(i=0; i<sumOddComb.length; i++){
    for(j=0; j<sumEvenComb.length; j++){
        val = sumEvenComb[j]+sumOddDigitArr- 2*(sumOddComb[i]);
        absval = val>0 ? val:-val;
        if(i==0&& j==0){
            absmin = absval;
        }
        else{
            absmin = (absmin> absval)? absval : absmin;
        }
        if(absmin==0) break;
    }
    if(absmin==0) break;
}
console.log("absmin= "+absmin%37);



//Additional Comments : Usually the output is 0 or 1 as there are 20 numbers and min comb differnce narrows down to 0 or 1 in almost every case.
// Looking for different output change the number of Random number being generated in for loop, try with small values 3,4,5..

