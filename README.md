Made using Unity 2020.3.25f1

Hardware Used: Windows 11 & Oculus Quest 2


Movement of the user is achieved by using the existing XR APIs to use joystick movement exclusively on the left controller/side. This results in movement that still follows the user wherever they look, but also allows for strafing movement

To enter the cart, gaze at the cart for 5 seconds. To exit the cart, look down for 5 seconds.

Hub teleportation works using gaze interaction on the white hubs, which teleports a raw image render texture of the overall map to the hub to interact with using buttons. When the user looks at a physics collider of any of these buttons and also presses the Select button on their controller, teleportation is initiated. If the user looks away from the big map and presses Select again, the map will disappear. The hubs also function as the feeding zones for convenience, colored based on what fruit they will collect nearby.

If the user wishes to toggle the minimap, the user can press the primary button on their controller (for the Quest controllers, it is the A key) and it will disable.

When the user collects a fruit, they look at the object, and presses the select button (for Quest controllers this is the grip trigger), and the object teleports into the fruit basket that is attached to the right hand of the user. When the user enters the teleport hub, if there is fruit in the box and the right bird flies overhead, the bird will eat the fruit.




Directory Hierarchy:

Roth Pond Scene

  Assets
  
      NVJOB Water Shaders V2
      For the lake shader
      
    3D Simple Building
      Background buildings
      
    Animated Loading Icons
  
    Example Assets
    
    Fantasy Environments
      For the trees
      
    living birds
      Used for bird prefabs
      
    Medieval village
    
    Otoh Art
    Fruit art and box art
    
    Planets of the Solar System 3D
    
    Samples
    
    Scenes
    
    Simple city plain
    
    TerrainSampleAssets
    
    UNDERPOLY- Free Hot-Air Balloons
    
    WorldMaterialsFree
    
    XR
    
    XRI

    ...




Made with free assets from the Unity store for educational purposes, linked here with thanks:
https://assetstore.unity.com/packages/3d/environments/3d-simple-building-hotel-213775

https://assetstore.unity.com/packages/2d/gui/icons/animated-loading-icons-47844

https://assetstore.unity.com/packages/3d/environments/fantasy-landscape-103573

https://assetstore.unity.com/packages/3d/environments/urban/simple-city-pack-plain-100348

https://assetstore.unity.com/packages/3d/environments/landscapes/terrain-sample-asset-pack-145808

https://assetstore.unity.com/packages/3d/vehicles/air/underpoly-free-hot-air-balloons-257931

https://assetstore.unity.com/packages/vfx/shaders/water-shaders-v2-x-149916

https://assetstore.unity.com/packages/3d/environments/fantasy/wooden-cart-65835

https://assetstore.unity.com/packages/2d/textures-materials/world-materials-free-150182

https://assetstore.unity.com/packages/3d/props/food/otoh-s-fruit-box-274072

https://assetstore.unity.com/packages/3d/characters/animals/birds/living-birds-15649

