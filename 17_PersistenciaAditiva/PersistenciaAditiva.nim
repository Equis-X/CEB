import strutils

proc AddNums(varx: var seq[int]): int =
    var
        res: int = 0
    for i in varx:
        res += i
    result = res

proc SeparateNums(nums: string): seq[int] =
    var num = newSeq[int](0)
    for i in nums:
        num.add(parseInt($i))
    result = num

proc DoOnce(numx: string): int =
        var
            num1 = SeparateNums(numx)
            num2 = AddNums(num1)
        if (num2 < 10):
            result = num2
        else:
            result = DoOnce(intToStr(num2))
    

proc PersistenciaAditiva(): int =
    var numx = readLine(stdin)
    if (parseInt(numx) < 10):
        result = parseInt(numx)
    else:
        result = DoOnce(numx)
            

echo "PERSISTANCIA ADITIVA\nInserte su numero:"
echo PersistenciaAditiva()
