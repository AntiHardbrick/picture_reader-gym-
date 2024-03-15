# preivew
![image](https://github.com/AntiHardbrick/picture_reader-gym-/assets/12881083/f1fa7104-4602-4ebb-bad6-0d160d184419)

read all PNG files in selected folder, and delete picture after readed.

require codes:
```python
rgb_array=env.render(mode = 'rgb_array')
```
(render to picture file)
```python
from PIL import Image

folder_path= "C:\\Users\\woongsan\\Desktop\\temp_folder"
im = Image.fromarray(rgb_array)
file_name= f"{datetime.datetime.now().timestamp()}.png"
im.save(os.path.join(folder_path,file_name))
```
(save picture, should naming with unix timestamp, +png extension)

click button '▶' to play (click again to stop)

# Warning
this viewer will delete all pictures in folder permenently after used.
make sure to use your selected/empty folder.
Recommend to double check selected folder path before play
