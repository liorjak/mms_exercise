import matplotlib.pyplot as plt
import numpy as np
import pandas as pd

from scipy.stats import pearsonr
from part_2.ex2.logic import calculate
from scipy.state import pearsonr


def plot_data() -> list:
    plt.style.use('_mpl-gallery')

    list_x = []
    numbers = calculate.get_the_list_of_numbers()
    for i in range(len(numbers)):
        list_x.append(i)

    x = np.array(list_x)

    list_y = []
    for i in range(len(numbers)):
        list_y.append(numbers[i])

    y = np.array(list_y)

    # plot
    fig, ax = plt.subplots()

    ax.scatter(x, y)

    ax.set(xlim=(0, 8), xticks=np.arange(1, 8),
           ylim=(0, 8), yticks=np.arange(1, 8))

    plt.show()
    return numbers


def calculate_pearson() -> None:
    numbers = plot_data()
    index = []
    for i in range(len(numbers) + 1):
        index.append(i)
    pearson_correlation, _ = pearsonr(index, numbers)
    return pearson_correlation
