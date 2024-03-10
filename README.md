# preivew
![image](https://github.com/AntiHardbrick/picture_reader-gym-/assets/12881083/f1fa7104-4602-4ebb-bad6-0d160d184419)

if your gym environment keep feezes while render, or want view your simulation more freely, 
try this viewer!

all you need to do is..

render with rgb_array
```python
rgb_array=env.render(mode = 'rgb_array')
```

and save this to specific folder
(file should be named with Unix timestamp to allow viewer to see the picture's generated time)
```python
from PIL import Image

folder_path= "C:\\Users\\woongsan\\Desktop\\temp_folder"
im = Image.fromarray(rgb_array)
file_name= f"{datetime.datetime.now().timestamp()}.png"
im.save(os.path.join(folder_path,file_name))
```

and done! just copy this folder path to viewer's path textbox
or click 'path' button, and select.

lastly click play'▶', and its really done. (click again to stop)

# !!Warning!!
this viewer will delete all pictures in folder permenently after used.
make sure to use your selected/empty folder.
Before click play button, double check your folder path selected correctly
