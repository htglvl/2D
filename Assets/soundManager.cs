using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.Audio;

public class soundManager : MonoBehaviour
{
    public soundPlayer[] soundPlayers;
    private bool voiceMuted = false, sfxMuted = false;
    
    void Awake() {
        foreach (soundPlayer s in soundPlayers)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.pitch = s.pitch;
            s.source.volume = s.volume;
        }
    }
    public void play(string name){
        soundPlayer s = Array.Find(soundPlayers, sound => sound.name == name);
        s.source.Play();
    }
    public bool isPlaying(String name){
        soundPlayer s = Array.Find(soundPlayers, sound => sound.name == name);
        return s.source.isPlaying;
    }
    public void muteVoice(String[] name){
        foreach (soundPlayer s in soundPlayers)
        {
            if (name.Contains(s.name)){
                s.source.volume = 0;
            }
        }
        voiceMuted = true;
    }
    public void unmuteVoice(String[] name){
        foreach (soundPlayer s in soundPlayers)
        {
            if (name.Contains(s.name)){
                s.source.volume = 1;
            }
        }
        voiceMuted = false;
    }
    public void muteSfx(String[] name){
        foreach (soundPlayer s in soundPlayers)
        {
            if (name.Contains(s.name)){
                s.source.volume = 0;
            }
        }
        sfxMuted = true;
    }
    public void unmuteSfx(String[] name){
        foreach (soundPlayer s in soundPlayers)
        {
            if (name.Contains(s.name)){
                s.source.volume = 1;
            }
        }
        sfxMuted = false;
    }
    public bool isSfxMuting(){
        return sfxMuted;
    }
    public bool isVoiceMuting(){
        return voiceMuted;
    }
}
