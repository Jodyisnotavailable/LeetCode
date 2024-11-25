/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    var map = new Map();

    for (let i = 0; i < nums.length; i ++) {
        //nums[i] + 2nd number = target sum
        //look for 2nd number
        let in2 = target - nums[i];
        if (map.has(in2)) {
            return [i, map.get(in2)];
        }
        map.set(nums[i], i);
    }
};
