package desenho;

import java.awt.Canvas;
import java.awt.Dimension;
import java.awt.Graphics;

import javax.swing.JFrame;

public class Quadrados_Girando extends Canvas {
	private static final long serialVersionUID = 1L;

	int maxX, maxY, minMaxXY, xCenter, xCenter_2, xCenter_3, xCenter_4, xCenter_5, xCenter_6, xCenter_7, xCenter_8, yCenter, yCenter_2,
	    yCenter_3, yCenter_4, yCenter_5, yCenter_6, yCenter_7, yCenter_8;
	void initgr() {
		Dimension d = getSize();
		maxX = d.width - 1;
		maxY = d.height - 1;
		minMaxXY = Math.min(maxX, maxY);
		xCenter = maxX / 2;
		xCenter_2 = (maxX/2) + 40;
		xCenter_3 = (maxX/2) + 80;
		xCenter_4 = (maxX/2) + 120;
		xCenter_5 = (maxX/2) + 160;
		xCenter_6 = (maxX/2) + 200;
		xCenter_7 = (maxX/2) + 240;
		xCenter_8 = (maxX/2) + 280;
		yCenter = maxY / 2;
		yCenter_2 = (maxY/2);
		yCenter_3 = (maxY/2);
		yCenter_4 = (maxY/2);
		yCenter_5 = (maxY/2);
		yCenter_6 = (maxY/2);
		yCenter_7 = (maxY/2);
		yCenter_8 = (maxY/2);
	}

	int iX(float x) {
		return Math.round(x);
	}

	int iY(float y) {
		return maxY - Math.round(y);
	}
	@Override
	public void paint(Graphics g) {
		super.paint(g);
		initgr();
		float  	xA, yA, xB, yB, xC, yD, xD,
				yC, xA1, yA1, xB1, yB1, xC1, yC1, xD1, yD1, p, q, p2, q2;
		
		
		q = 0.2F;
		p = 1 - q;
		
		for (int i = 0; i < 8; i++) {
			
			yCenter = yCenter + 40;
			
			xA = xCenter - 20; 
			yA = yCenter - 20; 
			xB = xCenter - 20; 
			yB = yCenter + 20;
			xC = xCenter + 20;
			yC = yCenter + 20; 
			xD = xCenter + 20;
			yD = yCenter - 20;

			
			for (int j = 0; j < 50; j++) {
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
		
		p2 = 0.2F;
		q2 = 1 - p2;
		
			for (int i = 0; i < 8; i++) {
			    
				yCenter_2 = yCenter_2 + 40;
			
			xA = xCenter_2 - 20; 
			yA = yCenter_2 - 20; 
			xB = xCenter_2 - 20; 
			yB = yCenter_2 + 20;
			xC = xCenter_2 + 20;
			yC = yCenter_2 + 20; 
			xD = xCenter_2 + 20;
			yD = yCenter_2 - 20;

			
			for (int j = 0; j < 50; j++) {
				g.drawLine(iX(xA), iY(yA), iX(xB), iY(yB));
				g.drawLine(iX(xB), iY(yB), iX(xC), iY(yC));
				g.drawLine(iX(xC), iY(yC), iX(xD), iY(yD));
				g.drawLine(iX(xD), iY(yD), iX(xA), iY(yA));
				xA1 = p2 * xA + q2 * xB;
				yA1 = p2 * yA + q2 * yB;
				xB1 = p2 * xB + q2 * xC;
				yB1 = p2 * yB + q2 * yC;
				xC1 = p2 * xC + q2 * xD;
				yC1 = p2 * yC + q2 * yD;
				xD1 = p2 * xD + q2 * xA;
				yD1 = p2 * yD + q2 * yA;
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
			
			q = 0.2F;
			p = 1 - q;
			
			for (int i = 0; i < 8; i++) {
				
				yCenter_3 = yCenter_3 + 40;
				
				xA = xCenter_3 - 20; 
				yA = yCenter_3 - 20; 
				xB = xCenter_3 - 20; 
				yB = yCenter_3 + 20;
				xC = xCenter_3 + 20;
				yC = yCenter_3 + 20; 
				xD = xCenter_3 + 20;
				yD = yCenter_3 - 20;

				
				for (int j = 0; j < 50; j++) {
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
			
			p2 = 0.2F;
			q2 = 1 - p2;
			
				for (int i = 0; i < 8; i++) {
				    
					yCenter_4 = yCenter_4 + 40;
				
				xA = xCenter_4 - 20; 
				yA = yCenter_4 - 20; 
				xB = xCenter_4 - 20; 
				yB = yCenter_4 + 20;
				xC = xCenter_4 + 20;
				yC = yCenter_4 + 20; 
				xD = xCenter_4 + 20;
				yD = yCenter_4 - 20;

				
				for (int j = 0; j < 50; j++) {
					g.drawLine(iX(xA), iY(yA), iX(xB), iY(yB));
					g.drawLine(iX(xB), iY(yB), iX(xC), iY(yC));
					g.drawLine(iX(xC), iY(yC), iX(xD), iY(yD));
					g.drawLine(iX(xD), iY(yD), iX(xA), iY(yA));
					xA1 = p2 * xA + q2 * xB;
					yA1 = p2 * yA + q2 * yB;
					xB1 = p2 * xB + q2 * xC;
					yB1 = p2 * yB + q2 * yC;
					xC1 = p2 * xC + q2 * xD;
					yC1 = p2 * yC + q2 * yD;
					xD1 = p2 * xD + q2 * xA;
					yD1 = p2 * yD + q2 * yA;
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
				
				q = 0.2F;
				p = 1 - q;
				
				for (int i = 0; i < 8; i++) {
					
					yCenter_5 = yCenter_5 + 40;
					
					xA = xCenter_5 - 20; 
					yA = yCenter_5 - 20; 
					xB = xCenter_5 - 20; 
					yB = yCenter_5 + 20;
					xC = xCenter_5 + 20;
					yC = yCenter_5 + 20; 
					xD = xCenter_5 + 20;
					yD = yCenter_5 - 20;

					
					for (int j = 0; j < 50; j++) {
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
				
				p2 = 0.2F;
				q2 = 1 - p2;
				
					for (int i = 0; i < 8; i++) {
					    
						yCenter_6 = yCenter_6 + 40;
					
					xA = xCenter_6 - 20; 
					yA = yCenter_6 - 20; 
					xB = xCenter_6 - 20; 
					yB = yCenter_6 + 20;
					xC = xCenter_6 + 20;
					yC = yCenter_6 + 20; 
					xD = xCenter_6 + 20;
					yD = yCenter_6 - 20;

					
					for (int j = 0; j < 50; j++) {
						g.drawLine(iX(xA), iY(yA), iX(xB), iY(yB));
						g.drawLine(iX(xB), iY(yB), iX(xC), iY(yC));
						g.drawLine(iX(xC), iY(yC), iX(xD), iY(yD));
						g.drawLine(iX(xD), iY(yD), iX(xA), iY(yA));
						xA1 = p2 * xA + q2 * xB;
						yA1 = p2 * yA + q2 * yB;
						xB1 = p2 * xB + q2 * xC;
						yB1 = p2 * yB + q2 * yC;
						xC1 = p2 * xC + q2 * xD;
						yC1 = p2 * yC + q2 * yD;
						xD1 = p2 * xD + q2 * xA;
						yD1 = p2 * yD + q2 * yA;
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
					
					q = 0.2F;
					p = 1 - q;
					
					for (int i = 0; i < 8; i++) {
						
						yCenter_7 = yCenter_7 + 40;
						
						xA = xCenter_7 - 20; 
						yA = yCenter_7 - 20; 
						xB = xCenter_7 - 20; 
						yB = yCenter_7 + 20;
						xC = xCenter_7 + 20;
						yC = yCenter_7 + 20; 
						xD = xCenter_7 + 20;
						yD = yCenter_7 - 20;

						
						for (int j = 0; j < 50; j++) {
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
					
					p2 = 0.2F;
					q2 = 1 - p2;
					
						for (int i = 0; i < 8; i++) {
						    
							yCenter_8 = yCenter_8 + 40;
						
						xA = xCenter_8 - 20; 
						yA = yCenter_8 - 20; 
						xB = xCenter_8 - 20; 
						yB = yCenter_8 + 20;
						xC = xCenter_8 + 20;
						yC = yCenter_8 + 20; 
						xD = xCenter_8 + 20;
						yD = yCenter_8 - 20;

						
						for (int j = 0; j < 50; j++) {
							g.drawLine(iX(xA), iY(yA), iX(xB), iY(yB));
							g.drawLine(iX(xB), iY(yB), iX(xC), iY(yC));
							g.drawLine(iX(xC), iY(yC), iX(xD), iY(yD));
							g.drawLine(iX(xD), iY(yD), iX(xA), iY(yA));
							xA1 = p2 * xA + q2 * xB;
							yA1 = p2 * yA + q2 * yB;
							xB1 = p2 * xB + q2 * xC;
							yB1 = p2 * yB + q2 * yC;
							xC1 = p2 * xC + q2 * xD;
							yC1 = p2 * yC + q2 * yD;
							xD1 = p2 * xD + q2 * xA;
							yD1 = p2 * yD + q2 * yA;
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
			
			
			
			
	
	}
	
	public static void main(String[] args) {
		JFrame frame = new JFrame("50 Quadrados");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize(600, 400);
		frame.add("Center", new Quadrados_Girando());
		frame.add(new Quadrados_Girando());
		frame.setVisible(true);
		
		
	}
}


