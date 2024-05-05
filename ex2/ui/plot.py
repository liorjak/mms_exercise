import matplotlib.pyplot as plt
import numpy as np

plt.style.use('_mpl-gallery')

# make the data
x = np.array([1,2,3,4,5,6])
y = np.array([1,2,3,4,5,6])

# plot
fig, ax = plt.subplots()

ax.scatter(x, y, vmin=0, vmax=100)

ax.set(xlim=(0, 8), xticks=np.arange(1, 8),
       ylim=(0, 8), yticks=np.arange(1, 8))

plt.show()
