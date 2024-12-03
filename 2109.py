class Solution:
    def addSpaces(self, s: str, spaces: List[int]) -> str:
        newS = []
        j = 0 #index for spaces
        finIndex = 0 #index for result string

        for i in range(len(s)):
            if j < len(spaces) and i == spaces[j]:
                newS.append(" ")
                finIndex += 1
                j +=1
            
            newS.append(s[i])
            finIndex +=1

        return "".join(newS)
