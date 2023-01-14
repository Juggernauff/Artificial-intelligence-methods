from sklearn.metrics import confusion_matrix, classification_report
from sklearn.model_selection import train_test_split
from sklearn.discriminant_analysis import LinearDiscriminantAnalysis
import matplotlib.pyplot as plt
import pandas as pnd

dataframe = pnd.read_csv('stroke_data.csv').dropna()

x = dataframe.drop('stroke', axis=1).values
y = dataframe['stroke'].values

x_train, x_test, y_train, y_test =  train_test_split(x, y, test_size=0.25, train_size=0.25, random_state=0)

model = LinearDiscriminantAnalysis()
model.fit(x_train, y_train)

predicted_y = model.predict(x_test)

print(classification_report(y_test, predicted_y))
print(confusion_matrix(y_test, predicted_y))

num_points = 500
fig, ax = plt.subplots(figsize=(10, 7))

ax.set_title('Линейный дискриминантный анализ')
ax.scatter(x_test[:num_points, 0] + x_test[:num_points, 1] + x_test[:num_points, 2] + x_test[:num_points, 3] + x_test[:num_points, 4]
           , x_test[:num_points, 5] + x_test[:num_points, 6] + x_test[:num_points, 7] + x_test[:num_points, 8] + x_test[:num_points, 9]
           , c=predicted_y[:num_points])
plt.show()