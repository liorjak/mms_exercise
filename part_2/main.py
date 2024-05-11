import math

from part_2.ex2.ui import prints
from part_2.ex2.ui import plot


def main():
    prints.print_len()

    print()
    sum = 1000
    prints.pythagorean_triplet_by_sum(sum)

    print()
    prints.print_is_sorted()

    print()
    prints.print_the_data()

    print()
    prints.print_pi_digits()


if __name__ == '__main__':
    main()
