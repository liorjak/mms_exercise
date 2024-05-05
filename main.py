def sorted_numbers(numbers: list) -> list:
    return sorted(numbers)


def count_of_positive_numbers(numbers: list) -> int:
    count_of_positive = 0
    for i in range(len(numbers)):
        if numbers[i] > 0:
            count_of_positive += 1
    return count_of_positive


def calculate_average(numbers: list) -> float:
    sum_of_numbers = 0
    for i in range(len(numbers)):
        sum_of_numbers += numbers[i]

    return sum_of_numbers / len(numbers)


def is_sorted_palindrome(word_to_check: str) -> bool:
    if word_to_check == reversed(word_to_check):
        for i in range((len(word_to_check) // 2) - 1):
            if word_to_check[i] > word_to_check[i + 1]:
                return False
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
    print()
    word_to_check = "cac"  # not working
    word_to_check = "abba"  # working
    print(is_sorted_palindrome(word_to_check))

    number = 0
    numbers = []
    while number != -1:
        number = float(input("Please enter a number (Press -1 for EXIT): "))
        if number == -1:
            break
        numbers.append(number)
    print(calculate_average(numbers))
    print(count_of_positive_numbers(numbers))
    print(sorted_numbers(numbers))


if __name__ == '__main__':
    main()
