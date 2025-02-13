import {AUTO, Scene} from "phaser";


export const myLevel = [
    [  0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0 ],
    [  0,   1,   1,   3,   0,   0,   0,   1,   1,   1,   0 ],
    [  0,   0,   0,   0,   0,   0,   0,   1,   1,   1,   0 ],
    [  0,   0,   0,   0,   0,   0,   0,   0,   1,   0,   0 ],
    [  0,   0,   0,  0,  1,  1,   0,   0,   1,   0,   0 ],
    [  4,   4,   4,   4,   4,   4,   4,   4,   4,   4,   4 ],
  ];
  

//js is much better suited at working with npm
//libraries. And F#-JS interop means that I don't
//have to write a ton of bindings. Sometimes F#
//is not good enough. Dynamic languages are better
//sometimes. And that's ok!
export function loadImage(scene, id, path){
    return scene.load.image(id,path);
}

export function addImage(scene, x,y, id){
    return scene.add.image(x,y,id);
}

export function setGOScale(gameObject, scale){
    gameObject.setScale(scale);
}

export function makeTileMap (scene,conf){
    return scene.make.tilemap(conf);
}

export function addTileSetImage (tilemap,id){
    return tilemap.addTilesetImage(id);
}

export function tilemapCreateLayer (tilemap,i,tiles,x,y){
    return tilemap.createLayer(i, tiles,x,y);
}

export function scaleLayer (tilemap, newScale){
    tilemap.layers.forEach((lyr) => {lyr.tilemapLayer.scale = newScale});
}

export function addSprite (scene, x, y, id){
    return scene.add.sprite(x,y,id);
}

export function loadTileMapCsv(scene,id, path){
    return scene.load.tilemapCSV(id,path);
}

export function addPhysicsSprite (scene, x,y,id){
    return scene.physics.add.sprite(x,y,id);
}

export function setCollideExclude(layer, arr){
    layer.setCollisionByExclusion(arr,true);
}

export function addCollider (scene, gameObject1, gameObject2){
    return scene.physics.add.collider(gameObject1, gameObject2);
}

export function layerSetColl(layer){
    layer.setCollisionBetween(1, 16, true, false, layer); 
}

export function tmSetColl (tilemap, arr){
    tilemap.setCollision(arr);
}


export function createConfig (scenes,w,h){
    const config = {
        type:AUTO,
        scene:scenes,
        pixelArt: true, //and this is absolutely amazing when working with aseprite!!
        width:w,
        height:h,
        physics : {
            default:"arcade",
            arcade:{
                gravity:{
                    y:200
                }
            }
        }
    }
    return config;
}


export class SceneXt extends Scene {
    constructor(conf,p,c,u){
        super(conf);
        this.p = p;
        this.c = c;
        this.u = u;
    }
    /*It is generally not a good idea to pass the instance
    as a parameter. In this case I'm doing it because it's
    the easiest way to "extend" the class (with composition)
    without writing a million bindings. Just know that this
    is normally taboo*/
    preload(){
        this.p(this);
    }
    create (){
        this.c(this);
    }
    update(time,delta){
        this.u(this,time,delta);
    }
}