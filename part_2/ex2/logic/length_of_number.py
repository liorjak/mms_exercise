import math


def num_len(number: int) -> int:
    return int(math.log10(abs(number)) + 1)
