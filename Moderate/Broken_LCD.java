/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package lcd;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;

public class Broken_LCD {

    public static void main(String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line, decimal, losDoce;
        String segmentos[];
        while ((line = buffer.readLine()) != null) {
            decimal = line.substring(line.lastIndexOf(";") + 1);
            boolean sePudo = false;

            losDoce = line.substring(0, 107);

            segmentos = losDoce.split(" ");
            int necesarios;
            int indicedelPunto;

            necesarios = decimal.length() - 1;

            indicedelPunto = decimal.lastIndexOf(".");
            for (int i = 0; i < segmentos.length; i++) {
                if ((segmentos.length - (i)) >= necesarios) {
                    int indicesSegmentos = i;
                    for (int j = 0; j < decimal.length(); j++) {
                        if (j == (indicedelPunto - 1)) {
                            if (compararNumeros(Integer.parseInt(decimal.charAt(j) + ""), segmentos[indicesSegmentos], true)) {
                                sePudo = true;
                                j++;
                            } else {
                                sePudo = false;

                                break;
                            }
                        } else {
                            if (compararNumeros(Integer.parseInt(decimal.charAt(j) + ""), segmentos[indicesSegmentos], false)) {
                                sePudo = true;

                            } else {
                                sePudo = false;
                                break;
                            }
                        }
                        indicesSegmentos++;
                    }
                    if (sePudo) {
                        break;
                    }
                } else {
                    sePudo = false;
                    break;
                }

            }
            if (sePudo) {
                System.out.println("1");
            } else {
                System.out.println("0");
            }

        }

    }

    public static boolean compararNumeros(int dec, String binario, boolean punto) {
        String[] numeros = new String[10];
        //primeros numeros sin puntos
        //1
        numeros[0] = "01100000";
        numeros[1] = "11011010";
        numeros[2] = "11110010";
        numeros[3] = "01100110";
        numeros[4] = "10110110";
        numeros[5] = "10111110";
        numeros[6] = "11100000";
        numeros[7] = "11111110";
        numeros[8] = "11110110";
        numeros[9] = "11111100";
        //con punto

        
        String comparar = "";

        if (punto) {
            for (int i = 0; i < numeros.length; i++) {
                numeros[i]=numeros[i].substring(0, 7)+"1";
                
            }
        }
        switch (dec) {
                case 1:
                    comparar = numeros[0];
                    break;
                case 2:
                    comparar = numeros[1];
                    break;
                case 3:
                    comparar = numeros[2];
                    break;
                case 4:
                    comparar = numeros[3];
                    break;
                case 5:
                    comparar = numeros[4];
                    break;
                case 6:
                    comparar = numeros[5];
                    break;
                case 7:
                    comparar = numeros[6];
                    break;
                case 8:
                    comparar = numeros[7];
                    break;
                case 9:
                    comparar = numeros[8];
                    break;
                case 0:
                    comparar = numeros[9];
                    break;
            }


        boolean sePuede = false;
        for (int i = 0; i < binario.length(); i++) {
            if (comparar.charAt(i) == '1') {
                if (binario.charAt(i) == '1') {
                    sePuede = true;
                } else {
                    sePuede = false;
                    break;
                }
            }

        }

        return sePuede;

    }
}
