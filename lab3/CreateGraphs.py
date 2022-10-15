# Part 4.
import matplotlib.pyplot as plt
from pathlib import Path
import pandas as pnd
import numpy as nmp

path = Path(Path.cwd(), 'lab3', 'dataFrame.csv')
dataFrame = pnd.read_csv(path, encoding='utf-16')

plt.plot(dataFrame['Оклад'], label = 'Salary')
plt.axhline (y=nmp.nanmean(dataFrame['Оклад'].mean()), color = 'red', linestyle = '--', linewidth = 2 , label = 'Mean')
plt.title('Salary and arithmetic average', loc = 'center')
plt.show()

plt.bar(dataFrame['Должность'], dataFrame['Оклад'])
plt.title('Positions and their salary', loc = 'center')
plt.show()

fig = plt.figure()
plt.hist(dataFrame['Пол'])
plt.title('Number of employees by gender')
plt.grid(True)
plt.show()