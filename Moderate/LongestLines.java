/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication52;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

/**
 *
 * @author Ariel
 */
public class LongestLines {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        int cantidad = Integer.parseInt(buffer.readLine());
        ArrayList al = new ArrayList();
        int i = 0;
        while ((line = buffer.readLine()) != null) {
            al.add(new lineas(line, line.length(), i));
            i++;
        }
        int mayor = 0;int indicemayor = 0;
        for (int j = 0; j < cantidad; j++) {
            for (int k = 0; k < al.size(); k++) {
                if (((lineas) al.get(k)).tamaño > ((lineas) al.get(indicemayor)).tamaño) {
                    indicemayor = k;
                }
            }
            System.out.println(((lineas) al.get(indicemayor)).mensaje);
            al.remove(indicemayor);
            indicemayor = 0;
        }
    }
}
class lineas {
    String mensaje;
    int tamaño;
    int index;
    public lineas(String mensaje, int tamaño, int index) {
        this.index = index;
        this.mensaje = mensaje;
        this.tamaño = tamaño;
    }
}