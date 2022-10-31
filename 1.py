class Solution(object):
    def getCommonPart(self, word):
        """
        :type word: str
        :rtype: str
        """
        lst = word.split()
        my_set = set(lst)
        my_dic = {}
        for s in my_set:
            if len(my_dic) == 0:
                my_dic[s] = 1
            else:
                for key in list(my_dic):
                    if s[:len(key)+1] == key:
                        my_dic[key] += 1
                    elif key[:len(s)+1] == s:
                        my_dic[s] = my_dic.pop(key)
                        my_dic[s] +=1
                    else:
                        my_dic[s] = 1


        return my_dic


# s = input()
s = "aoobc aoobb aoobd cdb cdbcc cc cdb"
sel = Solution()
print("-------------")
print(sel.getCommonPart(s))
