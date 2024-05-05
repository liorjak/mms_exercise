def is_palindrome(word_to_check: str) -> bool:
    if word_to_check == reversed(word_to_check):
        return True
    return False


def pythagorean_triplet_by_sum(sum: int) -> None:
    for a in range(sum - 2):
        for b in range(sum - a - 1):
            c = sum - a - b
            if a * a + b * b == c * c:
                print(f"{a} < {b} < {c}")


def num_len(number: int) -> int:
    length_of_number = 0
    while number > 0:
        number /= 10
        length_of_number += 1

    return length_of_number


def main():
    number = 555
    print(num_len(number))
    print()
    sum = 1000
    pythagorean_triplet_by_sum(sum)


if __name__ == '__main__':
    main()
