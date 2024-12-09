/**
 * @param {number[]} nums
 * @return {boolean}
 */
var isArraySpecial = function(nums) {
    for (let i = 0; i+1 < nums.length; i ++) {
        if (nums[i]%2 == nums[i+1]%2) return false;
    }

    return true;
};
