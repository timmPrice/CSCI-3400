# import pandas as pd
import subprocess

input = subprocess.check_output(['dotnet', 'run'])
input = input.decode('utf-8')
# input.split_string(',') > data frame
# string to float
# string(',') > data frame

print(input)
