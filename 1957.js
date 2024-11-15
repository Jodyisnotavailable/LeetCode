/**
 * @param {string} s
 * @return {string}
 */
var makeFancyString = function(s) {
    var count = 0;
    var lastChar = '';
    var ans  = "";
    for (let i = 0; i < s.length; i ++) {
        if (s.charAt(i) == lastChar) {
            count += 1
        } else {
            lastChar = s.charAt(i);
            count = 1;
        }

        if (count < 3) ans += s.charAt(i);
    }

    return ans
};
