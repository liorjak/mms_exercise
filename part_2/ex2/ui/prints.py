from part_2.ex2.logic import reverse_n_pi, length_of_number, calculate, palindrom
from part_2.ex2.ui import get_from_user


def print_pi_digits() -> None:
    n = 5
    pi_digits = reverse_n_pi.reverse_n_pi_digits(n)
    pi_digits_reverse = ""
    for i in range(len(pi_digits)):
        pi_digits_reverse += f"{pi_digits[len(pi_digits) - i - 1]}"
    print(f"For the number {n} the pi numbers is: {pi_digits_reverse}")


def calcs() -> None:
    numbers = []
    number = 0
    while number != -1:
        number = get_from_user.get_number_from_user()
        if number == -1:
            break
        numbers.append(number)
    print(calculate.calculate_average(numbers))
    print(calculate.count_of_positive_numbers(numbers))
    print(calculate.sorted_numbers(numbers))


def print_len() -> None:
    number = 555
    print(length_of_number.num_len(number))


def pythagorean_triplet_by_sum(sum: int) -> None:
    for a in range(sum - 2):
        for b in range(sum - a - 1):
            c = sum - a - b
            if a * a + b * b == c * c:
                print(f"{a} < {b} < {c}")


def print_is_sorted() -> None:
    word_to_check = "cac"   # not working
    word_to_check = "abba"  # working
    print(palindrom.is_sorted_palindrome(word_to_check))
