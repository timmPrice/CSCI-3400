# import pandas as pd
import subprocess

input = subprocess.check_output(['dotnet', 'run'])
input = input.decode('utf-8')
print(input)
