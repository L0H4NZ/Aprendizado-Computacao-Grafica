package desenho;

import java.awt.Canvas;
import java.awt.Dimension;
import java.awt.Graphics;

import javax.swing.JFrame;

public class Quadrado extends Canvas {
	private static final long serialVersionUID = 1L;

	int maxX, maxY, minMaxXY, xCenter, yCenter;

	void initgr() {
		Dimension d = getSize();
		maxX = d.width - 1;
		maxY = d.height - 1;
		minMaxXY = Math.min(maxX, maxY);
		xCenter = maxX / 2;
		yCenter = maxY / 2;
	}

	int iX(float x) {
		return Math.round(x);
	}

	int iY(float y) {
		return maxY - Math.round(y);
	}

	public void paint(Graphics g) {
		initgr();
		float  	xA, yA, xB, yB, xC, yD, xD,
				yC, xA1, yA1, xB1, yB1, xC1, yC1, xD1, yD1, p, q;
		q = 0.05F;
		p = 1 - q;
		xA = xCenter - 150; 
		yA = yCenter - 150; 
		xB = xCenter - 150; 
		yB = yCenter + 150;
		xC = xCenter + 150;
		yC = yCenter + 150; 
		xD = xCenter + 150;
		yD = yCenter - 150;

		
		
		
		for (int i = 0; i < 50; i++) {
			g.drawLine(iX(xA), iY(yA), iX(xB), iY(yB));
			g.drawLine(iX(xB), iY(yB), iX(xC), iY(yC));
			g.drawLine(iX(xC), iY(yC), iX(xD), iY(yD));
			g.drawLine(iX(xD), iY(yD), iX(xA), iY(yA));
			xA1 = p * xA + q * xB;
			yA1 = p * yA + q * yB;
			xB1 = p * xB + q * xC;
			yB1 = p * yB + q * yC;
			xC1 = p * xC + q * xD;
			yC1 = p * yC + q * yD;
			xD1 = p * xD + q * xA;
			yD1 = p * yD + q * yA;
			xA = xA1;
			xB = xB1;
			xC = xC1;
			xD = xD1;
			yA = yA1;
			yB = yB1;
			yC = yC1;
			yD = yD1;
			
		}
	}
	
	public static void main(String[] args) {
		JFrame frame = new JFrame("50 Quadrados");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize(600, 400);
		frame.add("Center", new Quadrado());
		frame.add(new Quadrado());
		frame.setVisible(true);
		
	}
}