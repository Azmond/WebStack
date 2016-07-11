﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmLib.Infrastructure
{
    public class Gsm7Alphabet : BaseAlphabet
    {
        //Задание алфавита
        protected override void InitAlphabet()
        {
            _dictionaryAlphabet.Add('@', 0x00);
            _dictionaryAlphabet.Add('£', 0x01);
            _dictionaryAlphabet.Add('$', 0x02);
            _dictionaryAlphabet.Add('¥', 0x03);
            _dictionaryAlphabet.Add('è', 0x04);
            _dictionaryAlphabet.Add('é', 0x05);
            _dictionaryAlphabet.Add('ù', 0x06);
            _dictionaryAlphabet.Add('ì', 0x07);
            _dictionaryAlphabet.Add('ò', 0x08);
            _dictionaryAlphabet.Add('Ç', 0x09);
            _dictionaryAlphabet.Add('\n', 0x0A);
            _dictionaryAlphabet.Add('Ø', 0x0B);
            _dictionaryAlphabet.Add('ø', 0x0C);
            _dictionaryAlphabet.Add('\r', 0x0D);
            _dictionaryAlphabet.Add('Å', 0x0E);
            _dictionaryAlphabet.Add('å', 0x0F);
            _dictionaryAlphabet.Add('Δ', 0x10);
            _dictionaryAlphabet.Add('_', 0x11);
            _dictionaryAlphabet.Add('Φ', 0x12);
            _dictionaryAlphabet.Add('Γ', 0x13);
            _dictionaryAlphabet.Add('Λ', 0x14);
            _dictionaryAlphabet.Add('Ω', 0x15);
            _dictionaryAlphabet.Add('Π', 0x16);
            _dictionaryAlphabet.Add('Ψ', 0x17);
            _dictionaryAlphabet.Add('Σ', 0x18);
            _dictionaryAlphabet.Add('Θ', 0x19);
            _dictionaryAlphabet.Add('Ξ', 0x1A);
            _dictionaryAlphabet.Add((char)27, 0x1B);
            _dictionaryAlphabet.Add('Æ', 0x1C);
            _dictionaryAlphabet.Add('æ', 0x1D);
            _dictionaryAlphabet.Add('ß', 0x1E);
            _dictionaryAlphabet.Add('É', 0x1F);
            _dictionaryAlphabet.Add(' ', 0x20);
            _dictionaryAlphabet.Add('!', 0x21);
            _dictionaryAlphabet.Add('"', 0x22);
            _dictionaryAlphabet.Add('#', 0x23);
            _dictionaryAlphabet.Add('¤', 0x24);
            _dictionaryAlphabet.Add('%', 0x25);
            _dictionaryAlphabet.Add('&', 0x26);
            _dictionaryAlphabet.Add('\'', 0x27);
            _dictionaryAlphabet.Add('(', 0x28);
            _dictionaryAlphabet.Add(')', 0x29);
            _dictionaryAlphabet.Add('*', 0x2A);
            _dictionaryAlphabet.Add('+', 0x2B);
            _dictionaryAlphabet.Add(',', 0x2C);
            _dictionaryAlphabet.Add('-', 0x2D);
            _dictionaryAlphabet.Add('.', 0x2E);
            _dictionaryAlphabet.Add('/', 0x2F);
            _dictionaryAlphabet.Add('0', 0x30);
            _dictionaryAlphabet.Add('1', 0x31);
            _dictionaryAlphabet.Add('2', 0x32);
            _dictionaryAlphabet.Add('3', 0x33);
            _dictionaryAlphabet.Add('4', 0x34);
            _dictionaryAlphabet.Add('5', 0x35);
            _dictionaryAlphabet.Add('6', 0x36);
            _dictionaryAlphabet.Add('7', 0x37);
            _dictionaryAlphabet.Add('8', 0x38);
            _dictionaryAlphabet.Add('9', 0x39);
            _dictionaryAlphabet.Add(':', 0x3A);
            _dictionaryAlphabet.Add(';', 0x3B);
            _dictionaryAlphabet.Add('<', 0x3C);
            _dictionaryAlphabet.Add('=', 0x3D);
            _dictionaryAlphabet.Add('>', 0x3E);
            _dictionaryAlphabet.Add('?', 0x3F);
            _dictionaryAlphabet.Add('¡', 0x40);
            _dictionaryAlphabet.Add('A', 0x41);
            _dictionaryAlphabet.Add('B', 0x42);
            _dictionaryAlphabet.Add('C', 0x43);
            _dictionaryAlphabet.Add('D', 0x44);
            _dictionaryAlphabet.Add('E', 0x45);
            _dictionaryAlphabet.Add('F', 0x46);
            _dictionaryAlphabet.Add('G', 0x47);
            _dictionaryAlphabet.Add('H', 0x48);
            _dictionaryAlphabet.Add('I', 0x49);
            _dictionaryAlphabet.Add('J', 0x4A);
            _dictionaryAlphabet.Add('K', 0x4B);
            _dictionaryAlphabet.Add('L', 0x4C);
            _dictionaryAlphabet.Add('M', 0x4D);
            _dictionaryAlphabet.Add('N', 0x4E);
            _dictionaryAlphabet.Add('O', 0x4F);
            _dictionaryAlphabet.Add('P', 0x50);
            _dictionaryAlphabet.Add('Q', 0x51);
            _dictionaryAlphabet.Add('R', 0x52);
            _dictionaryAlphabet.Add('S', 0x53);
            _dictionaryAlphabet.Add('T', 0x54);
            _dictionaryAlphabet.Add('U', 0x55);
            _dictionaryAlphabet.Add('V', 0x56);
            _dictionaryAlphabet.Add('W', 0x57);
            _dictionaryAlphabet.Add('X', 0x58);
            _dictionaryAlphabet.Add('Y', 0x59);
            _dictionaryAlphabet.Add('Z', 0x5A);
            _dictionaryAlphabet.Add('Ä', 0x5B);
            _dictionaryAlphabet.Add('Ö', 0x5C);
            _dictionaryAlphabet.Add('Ñ', 0x5D);
            _dictionaryAlphabet.Add('Ü', 0x5E);
            _dictionaryAlphabet.Add('§', 0x5F);
            _dictionaryAlphabet.Add('¿', 0x60);
            _dictionaryAlphabet.Add('a', 0x61);
            _dictionaryAlphabet.Add('b', 0x62);
            _dictionaryAlphabet.Add('c', 0x63);
            _dictionaryAlphabet.Add('d', 0x64);
            _dictionaryAlphabet.Add('e', 0x65);
            _dictionaryAlphabet.Add('f', 0x66);
            _dictionaryAlphabet.Add('g', 0x67);
            _dictionaryAlphabet.Add('h', 0x68);
            _dictionaryAlphabet.Add('i', 0x69);
            _dictionaryAlphabet.Add('j', 0x6A);
            _dictionaryAlphabet.Add('k', 0x6B);
            _dictionaryAlphabet.Add('l', 0x6C);
            _dictionaryAlphabet.Add('m', 0x6D);
            _dictionaryAlphabet.Add('n', 0x6E);
            _dictionaryAlphabet.Add('o', 0x6F);
            _dictionaryAlphabet.Add('p', 0x70);
            _dictionaryAlphabet.Add('q', 0x71);
            _dictionaryAlphabet.Add('r', 0x72);
            _dictionaryAlphabet.Add('s', 0x73);
            _dictionaryAlphabet.Add('t', 0x74);
            _dictionaryAlphabet.Add('u', 0x75);
            _dictionaryAlphabet.Add('v', 0x76);
            _dictionaryAlphabet.Add('w', 0x77);
            _dictionaryAlphabet.Add('x', 0x78);
            _dictionaryAlphabet.Add('y', 0x79);
            _dictionaryAlphabet.Add('z', 0x7A);
            _dictionaryAlphabet.Add('ä', 0x7B);
            _dictionaryAlphabet.Add('ö', 0x7C);
            _dictionaryAlphabet.Add('ñ', 0x7D);
            _dictionaryAlphabet.Add('ü', 0x7E);
            _dictionaryAlphabet.Add('à', 0x7F);
        }
    }
}