class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        res = [0] * len(temperatures)
        stack = [] #store index of lower temps

        for index, temp in enumerate(temperatures):
            #stack is not empty and current temp in list is higher than last pushed element
            while stack and temp > temperatures[stack[-1]]:
                poppedIndex = stack.pop()
                res[poppedIndex] = index - poppedIndex
            stack.append(index)

        return res
