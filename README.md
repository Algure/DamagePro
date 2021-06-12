# DamagePro
Damage player muscles.

## Editor.

The editor reveals that several body(parts) objects are arranged as children of a main gameobject.
This main object which is parent of the different body parts has an image component whose image value is the complete body image. The image components of the children also have values which are the various body parts as their names indicate.

The different buttons change the colors of the corresponding body parts by calling the `EnactTick` function in the manager script and passing the names or labels of the body parts they control into the `EnactTick` function all of which can be set on the editor.

The manager script only requires one public field to be specified in the editor which is the parent body object. It is used to find and initialise the image components of the different body parts.

There's also a reset button to reset all the body parts to the initial green color and discard the tick counts.

## Script.

The only script in the project is a scene manager script attached to the manager game object. Three dictionaries exist in this script: one to store the color configurations as stated in the initial docs; one to store the image components of the various body parts; and one to store the tick count for each body part.

The start function calls the `Refresh` function which is publicly accessible and is the same function called by the refresh button. This function initalises all dictionaries. The tick count dictionary has the body part labels as keys and all values are initialised to 0; The image dictionary stores the body part labels as keys and uses the parent object set in the editor to find the image components of the different body parts which become the values of the dictionary; The tick color/configuration dictionary stores the required tick counts as keys and their corresponding colors as values.

The `EnactTick` function increases the tick count dictionary value of the body part entry and calls a render function to change the color of the body parts' image according to the values of the configuration dictionary.
