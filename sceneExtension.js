import {AUTO, Scene} from "phaser";

export const myLevel = [
    [  0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0 ],
    [  0,   1,   1,   3,   0,   0,   0,   1,   1,   1,   0 ],
    [  0,   1,   1,   2,   0,   0,   0,   1,   1,   1,   0 ],
    [  0,   0,   0,   0,   0,   0,   0,   0,   1,   0,   0 ],
    [  0,   0,   0,  1,  1,  1,   0,   0,   1,   0,   0 ],
    [  0,   0,   0,   0,   0,   0,   0,   0,   1,   0,   0 ],
    [  0,   0,   0,   0,   0,   0,   0,   0,   1,   0,   0 ],
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