class Solution:
    import math
    def compressedString(self, word: str) -> str:
        res = ""
        count = 1
        curChr = word[0]

        for i in range(1, len(word)):
            if word[i] == curChr:
                count += 1
            else:
                if count > 9:
                    if count%9 == 0:
                        res += ("9" + curChr)*int((count/9))
                    else:
                        res += ("9" + curChr)*math.floor(count/9) + str(count%9) + curChr
                else:
                    res += str(count) + curChr
                
                curChr = word[i]
                count = 1

        if count > 9:
            if count%9 == 0:
                res += ("9" + curChr)*int((count/9))
            else:
                res += ("9" + curChr)*math.floor(count/9) + str(count%9) + curChr
        else:
            res += str(count) + curChr    

        return res
