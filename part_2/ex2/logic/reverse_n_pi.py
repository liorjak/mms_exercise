
import math


def reverse_n_pi_digits(n: int) -> list:
    string_pi = str(math.pi).split(".")
    numbers_after_dot = list(string_pi[1])
    return numbers_after_dot[0:n]

