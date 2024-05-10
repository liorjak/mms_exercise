from part_2.ex2.ui import get_from_user


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


def get_the_list_of_numbers() -> list:
    numbers = []
    number = 0

    while number != -1:
        number = get_from_user.get_number_from_user()
        if number == -1:
            break
        numbers.append(number)
    return numbers
