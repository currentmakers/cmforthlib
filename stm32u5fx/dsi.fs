\
\ @file dsi.fs
\ @brief DSI
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DSI Host version register
\ Address offset: 0x00
\ Reset value: 0x3134312A
\

$00000000 constant DSI_DSI_VR_VERSION                               \ Version of the DSI Host This read-only register contains the version of the DSI Host


\
\ @brief DSI Host control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_CR_EN                                    \ Enable This bit configures the DSI Host in either power-up mode or to reset.


\
\ @brief DSI Host clock control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_CCR_TXECKDIV                             \ TX escape clock division This field indicates the division factor for the TX escape clock source (lanebyteclk). The values 0 and 1 stop the TX_ESC clock generation.
$0000ff00 constant DSI_DSI_CCR_TOCKDIV                              \ Timeout clock division This field indicates the division factor for the timeout clock used as the timing unit in the configuration of HS to LP and LP to HS transition error.


\
\ @brief DSI Host LTDC VCID register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_LVCIDR_VCID                              \ Virtual channel ID These bits configure the virtual channel ID for the LTDC interface traffic.


\
\ @brief DSI Host LTDC color coding register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant DSI_DSI_LCOLCR_COLC                              \ Color coding This field configures the DPI color coding. Others: Reserved
$00000100 constant DSI_DSI_LCOLCR_LPE                               \ Loosely packet enable This bit enables the loosely packed variant to 18-bit configuration


\
\ @brief DSI Host LTDC polarity configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_LPCR_DEP                                 \ Data enable polarity This bit configures the polarity of data enable pin.
$00000002 constant DSI_DSI_LPCR_VSP                                 \ VSYNC polarity This bit configures the polarity of VSYNC pin.
$00000004 constant DSI_DSI_LPCR_HSP                                 \ HSYNC polarity This bit configures the polarity of HSYNC pin.


\
\ @brief DSI Host low-power mode configuration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_LPMCR_VLPSIZE                            \ VACT largest packet size This field is used for the transmission of commands in low-power mode. It defines the size, in bytes, of the largest packet that can fit in a line during VACT regions.
$00ff0000 constant DSI_DSI_LPMCR_LPSIZE                             \ Largest packet size This field is used for the transmission of commands in low-power mode. It defines the size, in bytes, of the largest packet that can fit in a line during VSA, VBP and VFP regions.


\
\ @brief DSI Host protocol configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_PCR_ETTXE                                \ EoTp transmission enable This bit enables the EoTP transmission.
$00000002 constant DSI_DSI_PCR_ETRXE                                \ EoTp reception enable This bit enables the EoTp reception.
$00000004 constant DSI_DSI_PCR_BTAE                                 \ Bus-turn-around enable This bit enables the bus-turn-around (BTA) request.
$00000008 constant DSI_DSI_PCR_ECCRXE                               \ ECC reception enable This bit enables the ECC reception, error correction and reporting.
$00000010 constant DSI_DSI_PCR_CRCRXE                               \ CRC reception enable This bit enables the CRC reception and error reporting.
$00000020 constant DSI_DSI_PCR_ETTXLPE                              \ EoTp transmission in low-power enable This bit enables the EoTP transmission in low-power.


\
\ @brief DSI Host generic VCID register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_GVCIDR_VCIDRX                            \ Virtual channel ID for reception This field indicates the generic interface read-back virtual channel identification.
$00030000 constant DSI_DSI_GVCIDR_VCIDTX                            \ Virtual channel ID for transmission This field indicates the generic interface virtual channel identification where the generic packet is automatically generated and transmitted.


\
\ @brief DSI Host mode configuration register
\ Address offset: 0x34
\ Reset value: 0x00000001
\

$00000001 constant DSI_DSI_MCR_CMDM                                 \ Command mode This bit configures the DSI Host in either video or command mode.


\
\ @brief DSI Host video mode configuration register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_VMCR_VMT                                 \ Video mode type This field configures the video mode transmission type : 1x: Burst mode
$00000100 constant DSI_DSI_VMCR_LPVSAE                              \ Low-power vertical sync active enable This bit enables to return to low-power inside the vertical sync time (VSA) period when timing allows.
$00000200 constant DSI_DSI_VMCR_LPVBPE                              \ Low-power vertical back-porch enable This bit enables to return to low-power inside the vertical back-porch (VBP) period when timing allows.
$00000400 constant DSI_DSI_VMCR_LPVFPE                              \ Low-power vertical front-porch enable This bit enables to return to low-power inside the vertical front-porch (VFP) period when timing allows.
$00000800 constant DSI_DSI_VMCR_LPVAE                               \ Low-power vertical active enable This bit enables to return to low-power inside the vertical active (VACT) period when timing allows.
$00001000 constant DSI_DSI_VMCR_LPHBPE                              \ Low-power horizontal back-porch enable This bit enables the return to low-power inside the horizontal back-porch (HBP) period when timing allows.
$00002000 constant DSI_DSI_VMCR_LPHFPE                              \ Low-power horizontal front-porch enable This bit enables the return to low-power inside the horizontal front-porch (HFP) period when timing allows.
$00004000 constant DSI_DSI_VMCR_FBTAAE                              \ Frame bus-turn-around acknowledge enable This bit enables the request for an acknowledge response at the end of a frame.
$00008000 constant DSI_DSI_VMCR_LPCE                                \ Low-power command enable This bit enables the command transmission only in low-power mode.
$00010000 constant DSI_DSI_VMCR_PGE                                 \ Pattern generator enable This bit enables the video mode pattern generator.
$00100000 constant DSI_DSI_VMCR_PGM                                 \ Pattern generator mode This bit configures the pattern generator mode.
$01000000 constant DSI_DSI_VMCR_PGO                                 \ Pattern generator orientation This bit configures the color bar orientation.


\
\ @brief DSI Host video packet configuration register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00003fff constant DSI_DSI_VPCR_VPSIZE                              \ Video packet size This field configures the number of pixels in a single video packet. For 18-bit not loosely packed data types, this number must be a multiple of 4. For YCbCr data types, it must be a multiple of 2 as described in the DSI specification.


\
\ @brief DSI Host video chunks configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00001fff constant DSI_DSI_VCCR_NUMC                                \ Number of chunks This register configures the number of chunks to be transmitted during a line period (a chunk consists of a video packet and a null packet). If set to 0 or 1, the video line is transmitted in a single packet. If set to 1, the packet is part of a chunk, so a null packet follows it if NPSIZE > 0. Otherwise, multiple chunks are used to transmit each video line.


\
\ @brief DSI Host video null packet configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00001fff constant DSI_DSI_VNPCR_NPSIZE                             \ Null packet size This field configures the number of bytes inside a null packet. Setting to 0 disables the null packets.


\
\ @brief DSI Host video HSA configuration register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000fff constant DSI_DSI_VHSACR_HSA                               \ Horizontal synchronism active duration This fields configures the horizontal synchronism active period in lane byte clock cycles.


\
\ @brief DSI Host video HBP configuration register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000fff constant DSI_DSI_VHBPCR_HBP                               \ Horizontal back-porch duration This fields configures the horizontal back-porch period in lane byte clock cycles.


\
\ @brief DSI Host video line configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00007fff constant DSI_DSI_VLCR_HLINE                               \ Horizontal line duration This fields configures the total of the horizontal line period (HSA+HBP+HACT+HFP) counted in lane byte clock cycles.


\
\ @brief DSI Host video VSA configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVSACR_VSA                               \ Vertical synchronism active duration This fields configures the vertical synchronism active period measured in number of horizontal lines.


\
\ @brief DSI Host video VBP configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVBPCR_VBP                               \ Vertical back-porch duration This fields configures the vertical back-porch period measured in number of horizontal lines.


\
\ @brief DSI Host video VFP configuration register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVFPCR_VFP                               \ Vertical front-porch duration This fields configures the vertical front-porch period measured in number of horizontal lines.


\
\ @brief DSI Host video VA configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00003fff constant DSI_DSI_VVACR_VA                                 \ Vertical active duration This fields configures the vertical active period measured in number of horizontal lines.


\
\ @brief DSI Host LTDC command configuration register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_LCCR_CMDSIZE                             \ Command size This field configures the maximum allowed size for an LTDC write memory command, measured in pixels. Automatic partitioning of data obtained from LTDC is permanently enabled.


\
\ @brief DSI Host command mode configuration register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_CMCR_TEARE                               \ Tearing effect acknowledge request enable This bit enables the tearing effect acknowledge request:
$00000002 constant DSI_DSI_CMCR_ARE                                 \ Acknowledge request enable This bit enables the acknowledge request after each packet transmission:
$00000100 constant DSI_DSI_CMCR_GSW0TX                              \ Generic short write zero parameters transmission This bit configures the generic short write packet with zero parameters command transmission type:
$00000200 constant DSI_DSI_CMCR_GSW1TX                              \ Generic short write one parameters transmission This bit configures the generic short write packet with one parameters command transmission type:
$00000400 constant DSI_DSI_CMCR_GSW2TX                              \ Generic short write two parameters transmission This bit configures the generic short write packet with two parameters command transmission type:
$00000800 constant DSI_DSI_CMCR_GSR0TX                              \ Generic short read zero parameters transmission This bit configures the generic short read packet with zero parameters command transmission type:
$00001000 constant DSI_DSI_CMCR_GSR1TX                              \ Generic short read one parameters transmission This bit configures the generic short read packet with one parameters command transmission type:
$00002000 constant DSI_DSI_CMCR_GSR2TX                              \ Generic short read two parameters transmission This bit configures the generic short read packet with two parameters command transmission type:
$00004000 constant DSI_DSI_CMCR_GLWTX                               \ Generic long write transmission This bit configures the generic long write packet command transmission type :
$00010000 constant DSI_DSI_CMCR_DSW0TX                              \ DCS short write zero parameter transmission This bit configures the DCS short write packet with zero parameter command transmission type:
$00020000 constant DSI_DSI_CMCR_DSW1TX                              \ DCS short read one parameter transmission This bit configures the DCS short read packet with one parameter command transmission type:
$00040000 constant DSI_DSI_CMCR_DSR0TX                              \ DCS short read zero parameter transmission This bit configures the DCS short read packet with zero parameter command transmission type:
$00080000 constant DSI_DSI_CMCR_DLWTX                               \ DCS long write transmission This bit configures the DCS long write packet command transmission type:
$01000000 constant DSI_DSI_CMCR_MRDPS                               \ Maximum read packet size This bit configures the maximum read packet size command transmission type:


\
\ @brief DSI Host generic header configuration register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000003f constant DSI_DSI_GHCR_DT                                  \ Type This field configures the packet data type of the header packet.
$000000c0 constant DSI_DSI_GHCR_VCID                                \ Channel This field configures the virtual channel ID of the header packet.
$0000ff00 constant DSI_DSI_GHCR_WCLSB                               \ WordCount LSB This field configures the less significant byte of the header packet word count for long packets, or data 0 for short packets.
$00ff0000 constant DSI_DSI_GHCR_WCMSB                               \ WordCount MSB This field configures the most significant byte of the header packet's word count for long packets, or data 1 for short packets.


\
\ @brief DSI Host generic payload data register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_GPDR_DATA1                               \ Payload byte 1 This field indicates the byte 1 of the packet payload.
$0000ff00 constant DSI_DSI_GPDR_DATA2                               \ Payload byte 2 This field indicates the byte 2 of the packet payload.
$00ff0000 constant DSI_DSI_GPDR_DATA3                               \ Payload byte 3 This field indicates the byte 3 of the packet payload.
$ff000000 constant DSI_DSI_GPDR_DATA4                               \ Payload byte 4 This field indicates the byte 4 of the packet payload.


\
\ @brief DSI Host generic packet status register
\ Address offset: 0x74
\ Reset value: 0x00050015
\

$00000001 constant DSI_DSI_GPSR_CMDFE                               \ Command FIFO empty This bit indicates the empty status of the generic command FIFO:
$00000002 constant DSI_DSI_GPSR_CMDFF                               \ Command FIFO full This bit indicates the full status of the generic command FIFO:
$00000004 constant DSI_DSI_GPSR_PWRFE                               \ Payload write FIFO empty This bit indicates the empty status of the generic write payload FIFO:
$00000008 constant DSI_DSI_GPSR_PWRFF                               \ Payload write FIFO full This bit indicates the full status of the generic write payload FIFO:
$00000010 constant DSI_DSI_GPSR_PRDFE                               \ Payload read FIFO empty This bit indicates the empty status of the generic read payload FIFO:
$00000020 constant DSI_DSI_GPSR_PRDFF                               \ Payload read FIFO full This bit indicates the full status of the generic read payload FIFO:
$00000040 constant DSI_DSI_GPSR_RCB                                 \ Read command busy This bit is set when a read command is issued and cleared when the entire response is stored in the FIFO:
$00010000 constant DSI_DSI_GPSR_CMDBE                               \ Command buffer empty This bit indicates the empty status of the generic payload internal buffer:
$00020000 constant DSI_DSI_GPSR_CMDBF                               \ Command buffer full This bit indicates the full status of the generic command internal buffer:
$00040000 constant DSI_DSI_GPSR_PBE                                 \ Payload buffer empty This bit indicates the empty status of the generic payload internal buffer:
$00080000 constant DSI_DSI_GPSR_PBF                                 \ Payload buffer full This bit indicates the full status of the generic payload internal buffer:


\
\ @brief DSI Host timeout counter configuration register 0
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR0_LPRX_TOCNT                         \ Low-power reception timeout counter This field configures the timeout counter that triggers a low-power reception timeout contention detection (measured in TOCKDIV cycles).
$ffff0000 constant DSI_DSI_TCCR0_HSTX_TOCNT                         \ High-speed transmission timeout counter This field configures the timeout counter that triggers a high-speed transmission timeout contention detection (measured in TOCKDIV cycles). If using the non-burst mode and there is no enough time to switch from high-speed to low-power and back in the period from one line data finishing to the next line sync start, the DSI link returns the low-power state once per frame, then configure the TOCKDIV and HSTX_TOCNT to be in accordance with: HSTX_TOCNT * lanebyteclkperiod * TOCKDIV â¥ the time of one FRAME data transmission *Â (1 + 10%) In burst mode, RGB pixel packets are time-compressed, leaving more time during a scan line. Therefore, if in burst mode and there is enough time to switch from high-speed to low-power and back in the period from one line data finishing to the next line sync start, the DSI link can return low-power mode and back in this time interval to save power. For this, configure the TOCKDIV and HSTX_TOCNT to be in accordance with: HSTX_TOCNT * lanebyteclkperiod * TOCKDIV â¥ the time of one LINE data transmission *Â (1Â +Â 10%)


\
\ @brief DSI Host timeout counter configuration register 1
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR1_HSRD_TOCNT                         \ High-speed read timeout counter This field sets a period for which the DSI Host keeps the link still, after sending a high-speed read operation. This period is measured in cycles of lanebyteclk. The counting starts when the D-PHY enters the Stop state and causes no interrupts.


\
\ @brief DSI Host timeout counter configuration register 2
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR2_LPRD_TOCNT                         \ Low-power read timeout counter This field sets a period for which the DSI Host keeps the link still, after sending a low-power read operation. This period is measured in cycles of lanebyteclk. The counting starts when the D-PHY enters the Stop state and causes no interrupts.


\
\ @brief DSI Host timeout counter configuration register 3
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR3_HSWR_TOCNT                         \ High-speed write timeout counter This field sets a period for which the DSI Host keeps the link inactive after sending a high-speed write operation. This period is measured in cycles of lanebyteclk. The counting starts when the D-PHY enters the Stop state and causes no interrupts.
$01000000 constant DSI_DSI_TCCR3_PM                                 \ Presp mode When set to 1, this bit ensures that the peripheral response timeout caused by HSWR_TOCNT is used only once per LTDC frame in command mode, when both the following conditions are met: dpivsync_edpiwms has risen and fallen. Packets originated from LTDC in command mode have been transmitted and its FIFO is empty again. In this scenario no non-LTDC command requests are sent to the D-PHY, even if there is traffic from generic interface ready to be sent, making it return to stop state. When it does so, PRESP_TO counter is activated and only when it finishes does the controller send any other traffic that is ready.


\
\ @brief DSI Host timeout counter configuration register 4
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR4_LPWR_TOCNT                         \ Low-power write timeout counter This field sets a period for which the DSI Host keeps the link still, after sending a low-power write operation. This period is measured in cycles of lanebyteclk. The counting starts when the D-PHY enters the Stop state and causes no interrupts.


\
\ @brief DSI Host timeout counter configuration register 5
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR5_BTA_TOCNT                          \ Bus-turn-around timeout counter This field sets a period for which the DSI Host keeps the link still, after completing a bus-turn-around. This period is measured in cycles of lanebyteclk. The counting starts when the DâPHY enters the Stop state and causes no interrupts.


\
\ @brief DSI Host clock lane configuration register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_CLCR_DPCC                                \ D-PHY clock control This bit controls the D-PHY clock state:
$00000002 constant DSI_DSI_CLCR_ACR                                 \ Automatic clock lane control This bit enables the automatic mechanism to stop providing clock in the clock lane when time allows.


\
\ @brief DSI Host clock lane timer configuration register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_CLTCR_LP2HS_TIME                         \ Low-power to high-speed time This field configures the maximum time that the D-PHY clock lane takes to go from lowâpower to high-speed transmission measured in lane byte clock cycles.
$03ff0000 constant DSI_DSI_CLTCR_HS2LP_TIME                         \ High-speed to low-power time This field configures the maximum time that the D-PHY clock lane takes to go from highâspeed to low-power transmission measured in lane byte clock cycles.


\
\ @brief DSI Host data lane timer configuration register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_DLTCR_LP2HS_TIME                         \ Low-power to high-speed time This field configures the maximum time that the D-PHY data lanes take to go from low-power to high-speed transmission measured in lane byte clock cycles.
$03ff0000 constant DSI_DSI_DLTCR_HS2LP_TIME                         \ High-speed to low-power time This field configures the maximum time that the D-PHY data lanes take to go from high-speed to low-power transmission measured in lane byte clock cycles.


\
\ @brief DSI Host PHY control register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000002 constant DSI_DSI_PCTLR_DEN                                \ Digital enable When set to 0, this bit places the digital section of the D-PHY in the reset state
$00000004 constant DSI_DSI_PCTLR_CKE                                \ Clock enable This bit enables the D-PHY clock lane module:


\
\ @brief DSI Host PHY configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000001
\

$00000003 constant DSI_DSI_PCONFR_NL                                \ Number of lanes This field configures the number of active data lanes: Others: Reserved
$0000ff00 constant DSI_DSI_PCONFR_SW_TIME                           \ Stop wait time This field configures the minimum wait period to request a high-speed transmission after the Stop state.


\
\ @brief DSI Host PHY ULPS control register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_PUCR_URCL                                \ ULPS request on clock lane ULPS mode request on clock lane.
$00000002 constant DSI_DSI_PUCR_UECL                                \ ULPS exit on clock lane ULPS mode exit on clock lane.
$00000004 constant DSI_DSI_PUCR_URDL                                \ ULPS request on data lane ULPS mode request on all active data lanes.
$00000008 constant DSI_DSI_PUCR_UEDL                                \ ULPS exit on data lane ULPS mode exit on all active data lanes.


\
\ @brief DSI Host PHY TX triggers configuration register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000000f constant DSI_DSI_PTTCR_TX_TRIG                            \ Transmission trigger Escape mode transmit trigger 0-3. Only one bit of TX_TRIG is asserted at any given time.


\
\ @brief DSI Host PHY status register
\ Address offset: 0xB0
\ Reset value: 0x00001528
\

$00000002 constant DSI_DSI_PSR_PD                                   \ PHY direction This bit indicates the status of phydirection D-PHY signal.
$00000004 constant DSI_DSI_PSR_PSSC                                 \ PHY stop state clock lane This bit indicates the status of phystopstateclklane D-PHY signal.
$00000008 constant DSI_DSI_PSR_UANC                                 \ ULPS active not clock lane This bit indicates the status of ulpsactivenotclklane D-PHY signal.
$00000010 constant DSI_DSI_PSR_PSS0                                 \ PHY stop state lane 0 This bit indicates the status of phystopstate0lane D-PHY signal.
$00000020 constant DSI_DSI_PSR_UAN0                                 \ ULPS active not lane 1 This bit indicates the status of ulpsactivenot0lane D-PHY signal.
$00000040 constant DSI_DSI_PSR_RUE0                                 \ RX ULPS escape lane 0 This bit indicates the status of rxulpsesc0lane D-PHY signal.
$00000080 constant DSI_DSI_PSR_PSS1                                 \ PHY stop state lane 1 This bit indicates the status of phystopstate1lane D-PHY signal.
$00000100 constant DSI_DSI_PSR_UAN1                                 \ ULPS active not lane 1 This bit indicates the status of ulpsactivenot1lane D-PHY signal.


\
\ @brief DSI Host interrupt and status register 0
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_ISR0_AE0                                 \ Acknowledge error 0 This bit retrieves the SoT error from the acknowledge error report.
$00000002 constant DSI_DSI_ISR0_AE1                                 \ Acknowledge error 1 This bit retrieves the SoT sync error from the acknowledge error report.
$00000004 constant DSI_DSI_ISR0_AE2                                 \ Acknowledge error 2 This bit retrieves the EoT sync error from the acknowledge error report.
$00000008 constant DSI_DSI_ISR0_AE3                                 \ Acknowledge error 3 This bit retrieves the escape mode entry command error from the acknowledge error report.
$00000010 constant DSI_DSI_ISR0_AE4                                 \ Acknowledge error 4 This bit retrieves the LP transmit sync error from the acknowledge error report.
$00000020 constant DSI_DSI_ISR0_AE5                                 \ Acknowledge error 5 This bit retrieves the peripheral timeout error from the acknowledge error report.
$00000040 constant DSI_DSI_ISR0_AE6                                 \ Acknowledge error 6 This bit retrieves the false control error from the acknowledge error report.
$00000080 constant DSI_DSI_ISR0_AE7                                 \ Acknowledge error 7 This bit retrieves the reserved (specific to the device) from the acknowledge error report.
$00000100 constant DSI_DSI_ISR0_AE8                                 \ Acknowledge error 8 This bit retrieves the ECC error, single-bit (detected and corrected) from the acknowledge error report.
$00000200 constant DSI_DSI_ISR0_AE9                                 \ Acknowledge error 9 This bit retrieves the ECC error, multi-bit (detected, not corrected) from the acknowledge error report.
$00000400 constant DSI_DSI_ISR0_AE10                                \ Acknowledge error 10 This bit retrieves the checksum error (long packet only) from the acknowledge error report.
$00000800 constant DSI_DSI_ISR0_AE11                                \ Acknowledge error 11 This bit retrieves the not recognized DSI data type from the acknowledge error report.
$00001000 constant DSI_DSI_ISR0_AE12                                \ Acknowledge error 12 This bit retrieves the DSI VC ID Invalid from the acknowledge error report.
$00002000 constant DSI_DSI_ISR0_AE13                                \ Acknowledge error 13 This bit retrieves the invalid transmission length from the acknowledge error report.
$00004000 constant DSI_DSI_ISR0_AE14                                \ Acknowledge error 14 This bit retrieves the reserved (specific to the device) from the acknowledge error report.
$00008000 constant DSI_DSI_ISR0_AE15                                \ Acknowledge error 15 This bit retrieves the DSI protocol violation from the acknowledge error report.
$00010000 constant DSI_DSI_ISR0_PE0                                 \ PHY error 0 This bit indicates the ErrEsc escape entry error from lane 0.
$00020000 constant DSI_DSI_ISR0_PE1                                 \ PHY error 1 This bit indicates the ErrSyncEsc low-power transmission synchronization error from lane 0.
$00040000 constant DSI_DSI_ISR0_PE2                                 \ PHY error 2 This bit indicates the ErrControl error from lane 0.
$00080000 constant DSI_DSI_ISR0_PE3                                 \ PHY error 3 This bit indicates the LP0 contention error ErrContentionLP0 from lane 0.
$00100000 constant DSI_DSI_ISR0_PE4                                 \ PHY error 4 This bit indicates the LP1 contention error ErrContentionLP1 from lane 0.


\
\ @brief DSI Host interrupt and status register 1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_ISR1_TOHSTX                              \ Timeout high-speed transmission This bit indicates that the high-speed transmission timeout counter reached the end and contention is detected.
$00000002 constant DSI_DSI_ISR1_TOLPRX                              \ Timeout low-power reception This bit indicates that the low-power reception timeout counter reached the end and contention is detected.
$00000004 constant DSI_DSI_ISR1_ECCSE                               \ ECC single-bit error This bit indicates that the ECC single error is detected and corrected in a received packet.
$00000008 constant DSI_DSI_ISR1_ECCME                               \ ECC multi-bit error This bit indicates that the ECC multiple error is detected in a received packet.
$00000010 constant DSI_DSI_ISR1_CRCE                                \ CRC error This bit indicates that the CRC error is detected in the received packet payload.
$00000020 constant DSI_DSI_ISR1_PSE                                 \ Packet size error This bit indicates that the packet size error is detected during the packet reception.
$00000040 constant DSI_DSI_ISR1_EOTPE                               \ EoTp error This bit indicates that the EoTp packet is not received at the end of the incoming peripheral transmission.
$00000080 constant DSI_DSI_ISR1_LPWRE                               \ LTDC payload write error This bit indicates that during a DPI pixel line storage, the payload FIFO becomes full and the data stored is corrupted.
$00000100 constant DSI_DSI_ISR1_GCWRE                               \ Generic command write error This bit indicates that the system tried to write a command through the generic interface and the FIFO is full. Therefore, the command is not written.
$00000200 constant DSI_DSI_ISR1_GPWRE                               \ Generic payload write error This bit indicates that the system tried to write a payload data through the generic interface and the FIFO is full. Therefore, the payload is not written.
$00000400 constant DSI_DSI_ISR1_GPTXE                               \ Generic payload transmit error This bit indicates that during a generic interface packet build, the payload FIFO becomes empty and corrupt data is sent.
$00000800 constant DSI_DSI_ISR1_GPRDE                               \ Generic payload read error This bit indicates that during a DCS read data, the payload FIFO becomes empty and the data sent to the interface is corrupted.
$00001000 constant DSI_DSI_ISR1_GPRXE                               \ Generic payload receive error This bit indicates that during a generic interface packet read back, the payload FIFO becomes full and the received data is corrupted.
$00080000 constant DSI_DSI_ISR1_PBUE                                \ Payload buffer underflow error This bit indicates that underflow has occurred when reading payload to build DSI packet for video mode.


\
\ @brief DSI Host interrupt enable register 0
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_IER0_AE0IE                               \ Acknowledge error 0 interrupt enable This bit enables the interrupt generation on acknowledge error 0.
$00000002 constant DSI_DSI_IER0_AE1IE                               \ Acknowledge error 1 interrupt enable This bit enables the interrupt generation on acknowledge error 1.
$00000004 constant DSI_DSI_IER0_AE2IE                               \ Acknowledge error 2 interrupt enable This bit enables the interrupt generation on acknowledge error 2.
$00000008 constant DSI_DSI_IER0_AE3IE                               \ Acknowledge error 3 interrupt enable This bit enables the interrupt generation on acknowledge error 3.
$00000010 constant DSI_DSI_IER0_AE4IE                               \ Acknowledge error 4 interrupt enable This bit enables the interrupt generation on acknowledge error 4.
$00000020 constant DSI_DSI_IER0_AE5IE                               \ Acknowledge error 5 interrupt enable This bit enables the interrupt generation on acknowledge error 5.
$00000040 constant DSI_DSI_IER0_AE6IE                               \ Acknowledge error 6 interrupt enable This bit enables the interrupt generation on acknowledge error 6.
$00000080 constant DSI_DSI_IER0_AE7IE                               \ Acknowledge error 7 interrupt enable This bit enables the interrupt generation on acknowledge error 7.
$00000100 constant DSI_DSI_IER0_AE8IE                               \ Acknowledge error 8 interrupt enable This bit enables the interrupt generation on acknowledge error 8.
$00000200 constant DSI_DSI_IER0_AE9IE                               \ Acknowledge error 9 interrupt enable This bit enables the interrupt generation on acknowledge error 9.
$00000400 constant DSI_DSI_IER0_AE10IE                              \ Acknowledge error 10 interrupt enable This bit enables the interrupt generation on acknowledge error 10.
$00000800 constant DSI_DSI_IER0_AE11IE                              \ Acknowledge error 11 interrupt enable This bit enables the interrupt generation on acknowledge error 11.
$00001000 constant DSI_DSI_IER0_AE12IE                              \ Acknowledge error 12 interrupt enable This bit enables the interrupt generation on acknowledge error 12.
$00002000 constant DSI_DSI_IER0_AE13IE                              \ Acknowledge error 13 interrupt enable This bit enables the interrupt generation on acknowledge error 13.
$00004000 constant DSI_DSI_IER0_AE14IE                              \ Acknowledge error 14 interrupt enable This bit enables the interrupt generation on acknowledge error 14.
$00008000 constant DSI_DSI_IER0_AE15IE                              \ Acknowledge error 15 interrupt enable This bit enables the interrupt generation on acknowledge error 15.
$00010000 constant DSI_DSI_IER0_PE0IE                               \ PHY error 0 interrupt enable This bit enables the interrupt generation on PHY error 0.
$00020000 constant DSI_DSI_IER0_PE1IE                               \ PHY error 1 interrupt enable This bit enables the interrupt generation on PHY error 1.
$00040000 constant DSI_DSI_IER0_PE2IE                               \ PHY error 2 interrupt enable This bit enables the interrupt generation on PHY error 2.
$00080000 constant DSI_DSI_IER0_PE3IE                               \ PHY error 3 interrupt enable This bit enables the interrupt generation on PHY error 4.
$00100000 constant DSI_DSI_IER0_PE4IE                               \ PHY error 4 interrupt enable This bit enables the interrupt generation on PHY error 4.


\
\ @brief DSI Host interrupt enable register 1
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_IER1_TOHSTXIE                            \ Timeout high-speed transmission interrupt enable This bit enables the interrupt generation on timeout high-speed transmission .
$00000002 constant DSI_DSI_IER1_TOLPRXIE                            \ Timeout low-power reception interrupt enable This bit enables the interrupt generation on timeout low-power reception.
$00000004 constant DSI_DSI_IER1_ECCSEIE                             \ ECC single-bit error interrupt enable This bit enables the interrupt generation on ECC single-bit error.
$00000008 constant DSI_DSI_IER1_ECCMEIE                             \ ECC multi-bit error interrupt enable This bit enables the interrupt generation on ECC multi-bit error.
$00000010 constant DSI_DSI_IER1_CRCEIE                              \ CRC error interrupt enable This bit enables the interrupt generation on CRC error.
$00000020 constant DSI_DSI_IER1_PSEIE                               \ Packet size error interrupt enable This bit enables the interrupt generation on packet size error.
$00000040 constant DSI_DSI_IER1_EOTPEIE                             \ EoTp error interrupt enable This bit enables the interrupt generation on EoTp error.
$00000080 constant DSI_DSI_IER1_LPWREIE                             \ LTDC payload write error interrupt enable This bit enables the interrupt generation on LTDC payload write error.
$00000100 constant DSI_DSI_IER1_GCWREIE                             \ Generic command write error interrupt enable This bit enables the interrupt generation on generic command write error.
$00000200 constant DSI_DSI_IER1_GPWREIE                             \ Generic payload write error interrupt enable This bit enables the interrupt generation on generic payload write error.
$00000400 constant DSI_DSI_IER1_GPTXEIE                             \ Generic payload transmit error interrupt enable This bit enables the interrupt generation on generic payload transmit error.
$00000800 constant DSI_DSI_IER1_GPRDEIE                             \ Generic payload read error interrupt enable This bit enables the interrupt generation on generic payload read error.
$00001000 constant DSI_DSI_IER1_GPRXEIE                             \ Generic payload receive error interrupt enable This bit enables the interrupt generation on generic payload receive error.
$00080000 constant DSI_DSI_IER1_PBUEIE                              \ Payload buffer underflow error interrupt enable This bit enables the interrupt generation on payload buffer underflow error.


\
\ @brief DSI Host force interrupt register 0
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_FIR0_FAE0                                \ Force acknowledge error 0 Writing one to this bit forces an acknowledge error 0.
$00000002 constant DSI_DSI_FIR0_FAE1                                \ Force acknowledge error 1 Writing one to this bit forces an acknowledge error 1.
$00000004 constant DSI_DSI_FIR0_FAE2                                \ Force acknowledge error 2 Writing one to this bit forces an acknowledge error 2.
$00000008 constant DSI_DSI_FIR0_FAE3                                \ Force acknowledge error 3 Writing one to this bit forces an acknowledge error 3.
$00000010 constant DSI_DSI_FIR0_FAE4                                \ Force acknowledge error 4 Writing one to this bit forces an acknowledge error 4.
$00000020 constant DSI_DSI_FIR0_FAE5                                \ Force acknowledge error 5 Writing one to this bit forces an acknowledge error 5.
$00000040 constant DSI_DSI_FIR0_FAE6                                \ Force acknowledge error 6 Writing one to this bit forces an acknowledge error 6.
$00000080 constant DSI_DSI_FIR0_FAE7                                \ Force acknowledge error 7 Writing one to this bit forces an acknowledge error 7.
$00000100 constant DSI_DSI_FIR0_FAE8                                \ Force acknowledge error 8 Writing one to this bit forces an acknowledge error 8.
$00000200 constant DSI_DSI_FIR0_FAE9                                \ Force acknowledge error 9 Writing one to this bit forces an acknowledge error 9.
$00000400 constant DSI_DSI_FIR0_FAE10                               \ Force acknowledge error 10 Writing one to this bit forces an acknowledge error 10.
$00000800 constant DSI_DSI_FIR0_FAE11                               \ Force acknowledge error 11 Writing one to this bit forces an acknowledge error 11.
$00001000 constant DSI_DSI_FIR0_FAE12                               \ Force acknowledge error 12 Writing one to this bit forces an acknowledge error 12.
$00002000 constant DSI_DSI_FIR0_FAE13                               \ Force acknowledge error 13 Writing one to this bit forces an acknowledge error 13.
$00004000 constant DSI_DSI_FIR0_FAE14                               \ Force acknowledge error 14 Writing one to this bit forces an acknowledge error 14.
$00008000 constant DSI_DSI_FIR0_FAE15                               \ Force acknowledge error 15 Writing one to this bit forces an acknowledge error 15.
$00010000 constant DSI_DSI_FIR0_FPE0                                \ Force PHY error 0 Writing one to this bit forces a PHY error 0.
$00020000 constant DSI_DSI_FIR0_FPE1                                \ Force PHY error 1 Writing one to this bit forces a PHY error 1.
$00040000 constant DSI_DSI_FIR0_FPE2                                \ Force PHY error 2 Writing one to this bit forces a PHY error 2.
$00080000 constant DSI_DSI_FIR0_FPE3                                \ Force PHY error 3 Writing one to this bit forces a PHY error 3.
$00100000 constant DSI_DSI_FIR0_FPE4                                \ Force PHY error 4 Writing one to this bit forces a PHY error 4.


\
\ @brief DSI Host force interrupt register 1
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_FIR1_FTOHSTX                             \ Force timeout high-speed transmission Writing one to this bit forces a timeout high-speed transmission.
$00000002 constant DSI_DSI_FIR1_FTOLPRX                             \ Force timeout low-power reception Writing one to this bit forces a timeout low-power reception.
$00000004 constant DSI_DSI_FIR1_FECCSE                              \ Force ECC single-bit error Writing one to this bit forces a ECC single-bit error.
$00000008 constant DSI_DSI_FIR1_FECCME                              \ Force ECC multi-bit error Writing one to this bit forces a ECC multi-bit error.
$00000010 constant DSI_DSI_FIR1_FCRCE                               \ Force CRC error Writing one to this bit forces a CRC error.
$00000020 constant DSI_DSI_FIR1_FPSE                                \ Force packet size error Writing one to this bit forces a packet size error.
$00000040 constant DSI_DSI_FIR1_FEOTPE                              \ Force EoTp error Writing one to this bit forces a EoTp error.
$00000080 constant DSI_DSI_FIR1_FLPWRE                              \ Force LTDC payload write error Writing one to this bit forces a LTDC payload write error.
$00000100 constant DSI_DSI_FIR1_FGCWRE                              \ Force generic command write error Writing one to this bit forces a generic command write error.
$00000200 constant DSI_DSI_FIR1_FGPWRE                              \ Force generic payload write error Writing one to this bit forces a generic payload write error.
$00000400 constant DSI_DSI_FIR1_FGPTXE                              \ Force generic payload transmit error Writing one to this bit forces a generic payload transmit error.
$00000800 constant DSI_DSI_FIR1_FGPRDE                              \ Force generic payload read error Writing one to this bit forces a generic payload read error.
$00001000 constant DSI_DSI_FIR1_FGPRXE                              \ Force generic payload receive error Writing one to this bit forces a generic payload receive error.
$00080000 constant DSI_DSI_FIR1_FPBUE                               \ Force payload buffer underflow error Writing one to this bit forces a payload undrflow error.


\
\ @brief DSI Host data lane timer read configuration register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00007fff constant DSI_DSI_DLTRCR_MRD_TIME                          \ Maximum read time This field configures the maximum time required to perform a read command in lane byte clock cycles. This register can only be modified when no read command is in progress.


\
\ @brief DSI Host video shadow control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_VSCR_EN                                  \ Enable When set to 1, DSI Host LTDC interface receives the active configuration from the auxiliary registers. When this bit is set along with the UR bit, the auxiliary registers are automatically updated.
$00000100 constant DSI_DSI_VSCR_UR                                  \ Update register When set to 1, the LTDC registers are copied to the auxiliary registers. After copying, this bit is auto cleared.


\
\ @brief DSI Host LTDC current VCID register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_LCVCIDR_VCID                             \ Virtual channel ID This field returns the virtual channel ID for the LTDC interface.


\
\ @brief DSI Host LTDC current color coding register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000000f constant DSI_DSI_LCCCR_COLC                               \ Color coding This field returns the current LTDC interface color coding. 0110-1111: reserved If LTDC interface in command mode is chosen and currently works in the command mode (CMDM=1), then 0110-1111: 24-bit
$00000100 constant DSI_DSI_LCCCR_LPE                                \ Loosely packed enable This bit returns the current state of the loosely packed variant to 18-bit configurations.


\
\ @brief DSI Host low-power mode current configuration register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_LPMCCR_VLPSIZE                           \ VACT largest packet size This field returns the current size, in bytes, of the largest packet that can fit in a line during VACT regions, for the transmission of commands in low-power mode.
$00ff0000 constant DSI_DSI_LPMCCR_LPSIZE                            \ Largest packet size This field is returns the current size, in bytes, of the largest packet that can fit in a line during VSA, VBP and VFP regions, for the transmission of commands in low-power mode.


\
\ @brief DSI Host video mode current configuration register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_VMCCR_VMT                                \ Video mode type This field returns the current video mode transmission type: 1x: Burst mode
$00000004 constant DSI_DSI_VMCCR_LPVSAE                             \ Low-power vertical sync time enable This bit returns the current state of return to low-power inside the vertical sync time (VSA) period when timing allows.
$00000008 constant DSI_DSI_VMCCR_LPVBPE                             \ Low-power vertical back-porch enable This bit returns the current state of return to low-power inside the vertical back-porch (VBP) period when timing allows.
$00000010 constant DSI_DSI_VMCCR_LPVFPE                             \ Low-power vertical front-porch enable This bit returns the current state of return to low-power inside the vertical front-porch (VFP) period when timing allows.
$00000020 constant DSI_DSI_VMCCR_LPVAE                              \ Low-power vertical active enable This bit returns the current state of return to low-power inside the vertical active (VACT) period when timing allows.
$00000040 constant DSI_DSI_VMCCR_LPHBPE                             \ Low-power horizontal back-porch enable This bit returns the current state of return to low-power inside the horizontal back-porch (HBP) period when timing allows.
$00000080 constant DSI_DSI_VMCCR_LPHFE                              \ Low-power horizontal front-porch enable This bit returns the current state of return to low-power inside the horizontal front-porch (HFP) period when timing allows.
$00000100 constant DSI_DSI_VMCCR_FBTAAE                             \ Frame BTA acknowledge enable This bit returns the current state of request for an acknowledge response at the end of a frame.
$00000200 constant DSI_DSI_VMCCR_LPCE                               \ Low-power command enable This bit returns the current command transmission state in low-power mode.


\
\ @brief DSI Host video packet current configuration register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00003fff constant DSI_DSI_VPCCR_VPSIZE                             \ Video packet size This field returns the number of pixels in a single video packet.


\
\ @brief DSI Host video chunks current configuration register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00001fff constant DSI_DSI_VCCCR_NUMC                               \ Number of chunks This field returns the number of chunks being transmitted during a line period.


\
\ @brief DSI Host video null packet current configuration register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00001fff constant DSI_DSI_VNPCCR_NPSIZE                            \ Null packet size This field returns the number of bytes inside a null packet.


\
\ @brief DSI Host video HSA current configuration register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000fff constant DSI_DSI_VHSACCR_HSA                              \ Horizontal synchronism active duration This fields returns the horizontal synchronism active period in lane byte clock cycles.


\
\ @brief DSI Host video HBP current configuration register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000fff constant DSI_DSI_VHBPCCR_HBP                              \ Horizontal back-porch duration This field returns the horizontal back-porch period in lane byte clock cycles.


\
\ @brief DSI Host video line current configuration register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00007fff constant DSI_DSI_VLCCR_HLINE                              \ Horizontal line duration This field returns the current total of the horizontal line period (HSA+HBP+HACT+HFP) counted in lane byte clock cycles.


\
\ @brief DSI Host video VSA current configuration register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVSACCR_VSA                              \ Vertical synchronism active duration This field returns the current vertical synchronism active period measured in number of horizontal lines.


\
\ @brief DSI Host video VBP current configuration register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVBPCCR_VBP                              \ Vertical back-porch duration This field returns the current vertical back-porch period measured in number of horizontal lines.


\
\ @brief DSI Host video VFP current configuration register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVFPCCR_VFP                              \ Vertical front-porch duration This field returns the current vertical front-porch period measured in number of horizontal lines.


\
\ @brief DSI Host video VA current configuration register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00003fff constant DSI_DSI_VVACCR_VA                                \ Vertical active duration This field returns the current vertical active period measured in number of horizontal lines.


\
\ @brief DSI Host FIFO and buffer status register
\ Address offset: 0x168
\ Reset value: 0x00050015
\

$00000001 constant DSI_DSI_FBSR_VCWFE                               \ Video mode command write FIFO empty This bit indicates the empty status of the video mode write command FIFO:
$00000002 constant DSI_DSI_FBSR_VCWFF                               \ Video mode command write FIFO full This bit indicates the full status of the video mode write command FIFO:
$00000004 constant DSI_DSI_FBSR_VPWFE                               \ Video mode payload write FIFO empty This bit indicates the empty status of the video mode write payload FIFO:
$00000008 constant DSI_DSI_FBSR_VPWFF                               \ Video mode payload write FIFO full This bit indicates the full status of the video mode write payload FIFO:
$00000010 constant DSI_DSI_FBSR_ACWFE                               \ Adapted command mode command write FIFO empty This bit indicates the empty status of the adapted command mode write command FIFO:
$00000020 constant DSI_DSI_FBSR_ACWFF                               \ Adapted command mode command write FIFO full This bit indicates the full status of the adapted command mode write command FIFO:
$00000040 constant DSI_DSI_FBSR_APWFE                               \ Adapted command mode payload write FIFO empty This bit indicates the empty status of the adapted command mode write payload FIFO:
$00000080 constant DSI_DSI_FBSR_APWFF                               \ Adapted command mode payload write FIFO full This bit indicates the full status of the adapted command mode write payload FIFO:
$00010000 constant DSI_DSI_FBSR_VPBE                                \ Video mode payload buffer empty This bit indicates the empty status of the video mode payload internal buffer:
$00020000 constant DSI_DSI_FBSR_VPBF                                \ Video mode payload buffer full This bit indicates the full status of the video mode payload internal buffer:
$00100000 constant DSI_DSI_FBSR_ACBE                                \ Adapted command mode command buffer empty This bit indicates the empty status of the adapted command mode command internal buffer:
$00200000 constant DSI_DSI_FBSR_ACBF                                \ Adapted command mode command buffer full This bit indicates the full status of the adapted command mode command internal buffer:
$00400000 constant DSI_DSI_FBSR_APBE                                \ Adapted command mode payload buffer empty This bit indicates the empty status of the adapted command mode payload internal buffer:
$00800000 constant DSI_DSI_FBSR_APBF                                \ Adapted command mode payload buffer full This bit indicates the full status of the adapted command mode payload internal buffer:


\
\ @brief DSI Wrapper configuration register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WCFGR_DSIM                               \ DSI mode This bit selects the mode for the video transmission. This bit must only be changed when DSI Host is stopped (DSI_CR.EN = 0).
$0000000e constant DSI_DSI_WCFGR_COLMUX                             \ Color multiplexing This bit selects the color multiplexing used by DSI Host. This field must only be changed when DSI is stopped (DSI_WCR.DSIEN = 0 and DSI_CR.ENÂ =Â 0).
$00000010 constant DSI_DSI_WCFGR_TESRC                              \ TE source This bit selects the tearing effect (TE) source. This bit must only be changed when DSI Host is stopped (DSI_CR.EN = 0).
$00000020 constant DSI_DSI_WCFGR_TEPOL                              \ TE polarity This bit selects the polarity of the external pin tearing effect (TE) source. This bit must only be changed when DSI Host is stopped (DSI_CR.EN = 0).
$00000040 constant DSI_DSI_WCFGR_AR                                 \ Automatic refresh This bit selects the refresh mode in DBI mode. This bit must only be changed when DSI Host is stopped (DSI_CR.EN = 0).
$00000080 constant DSI_DSI_WCFGR_VSPOL                              \ VSync polarity This bit selects the VSync edge on which the LTDC is halted. This bit must only be changed when DSI is stopped (DSI_WCR.DSIEN = 0 and DSI_CR.ENÂ =Â 0).


\
\ @brief DSI Wrapper control register
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WCR_COLM                                 \ Color mode This bit controls the display color mode in video mode.
$00000002 constant DSI_DSI_WCR_SHTDN                                \ Shutdown This bit controls the display shutdown in video mode.
$00000004 constant DSI_DSI_WCR_LTDCEN                               \ LTDC enable This bit enables the LTDC for a frame transfer in adapted command mode.
$00000008 constant DSI_DSI_WCR_DSIEN                                \ DSI enable This bit enables the DSI Wrapper.


\
\ @brief DSI Wrapper interrupt enable register
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WIER_TEIE                                \ Tearing effect interrupt enable This bit enables the tearing effect interrupt.
$00000002 constant DSI_DSI_WIER_ERIE                                \ End of refresh interrupt enable This bit enables the end of refresh interrupt.
$00000200 constant DSI_DSI_WIER_PLLLIE                              \ PLL lock interrupt enable This bit enables the PLL lock interrupt.
$00000400 constant DSI_DSI_WIER_PLLUIE                              \ PLL unlock interrupt enable This bit enables the PLL unlock interrupt.


\
\ @brief DSI Wrapper interrupt and status register
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WISR_TEIF                                \ Tearing effect interrupt flag This bit is set when a tearing effect event occurs.
$00000002 constant DSI_DSI_WISR_ERIF                                \ End of refresh interrupt flag This bit is set when the transfer of a frame in adapted command mode is finished.
$00000004 constant DSI_DSI_WISR_BUSY                                \ Busy flag This bit is set when the transfer of a frame in adapted command mode is ongoing.
$00000100 constant DSI_DSI_WISR_PLLLS                               \ PLL lock status This bit is set when the PLL is locked and cleared when it is unlocked.
$00000200 constant DSI_DSI_WISR_PLLLIF                              \ PLL lock interrupt flag This bit is set when the PLL becomes locked.
$00000400 constant DSI_DSI_WISR_PLLUIF                              \ PLL unlock interrupt flag This bit is set when the PLL becomes unlocked.


\
\ @brief DSI Wrapper interrupt flag clear register
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WIFCR_CTEIF                              \ Clear tearing effect interrupt flag Write 1 clears the TEIF flag in the DSI_WSR register.
$00000002 constant DSI_DSI_WIFCR_CERIF                              \ Clear end of refresh interrupt flag Write 1 clears the ERIF flag in the DSI_WSR register.
$00000200 constant DSI_DSI_WIFCR_CPLLLIF                            \ Clear PLL lock interrupt flag Write 1 clears the PLLLIF flag in the DSI_WSR register.
$00000400 constant DSI_DSI_WIFCR_CPLLUIF                            \ Clear PLL unlock interrupt flag Write 1 clears the PLLUIF flag in the DSI_WSR register.


\
\ @brief DSI Wrapper PHY configuration register 0
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$00000040 constant DSI_DSI_WPCR0_SWCL                               \ Swap clock lane pins This bit swaps the pins on clock lane.
$00000080 constant DSI_DSI_WPCR0_SWDL0                              \ Swap data lane 0 pins This bit swaps the pins on data lane 0.
$00000100 constant DSI_DSI_WPCR0_SWDL1                              \ Swap data lane 1 pins This bit swaps the pins on clock lane.
$00001000 constant DSI_DSI_WPCR0_FTXSMCL                            \ Force in TX Stop mode the clock lane This bit forces the clock lane in TX stop mode. It is used to initialize a lane module in transmit mode. It causes the lane module to immediately jump to transmit control mode and to begin transmitting a stop state (LP-11). It can be used to go back in TX mode after a wrong BTA sequence.
$00002000 constant DSI_DSI_WPCR0_FTXSMDL                            \ Force in TX Stop mode the data lanes This bit forces the data lanes in TX stop mode. It is used to initialize a lane module in transmit mode. It causes the lane module to immediately jump to transmit control mode and to begin transmitting a stop state (LP-11). It can be used to go back in TX mode after a wrong BTA sequence.


\
\ @brief DSI Wrapper regulator and PLL control register
\ Address offset: 0x430
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WRPCR_PLLEN                              \ PLL enable This bit enables the D-PHY PLL.
$000007fc constant DSI_DSI_WRPCR_NDIV                               \ PLL loop division factor This field configures the PLL loop division factor. 2: PLL loop divided by 2x2 ... 511: PLL loop divided by 511x2
$000ff800 constant DSI_DSI_WRPCR_IDF                                \ PLL input division factor This field configures the PLL input division factor. 2: PLL input divided by 2 ... 511: PLL input divided by 511
$1ff00000 constant DSI_DSI_WRPCR_ODF                                \ PLL output division factor This field configures the PLL output division factor. 2: PLL output divided by 2 ... 511: PLL output divided by 511


\
\ @brief DSI bias configuration register
\ Address offset: 0x808
\ Reset value: 0x00000000
\

$00000040 constant DSI_DSI_BCFGR_PWRUP                              \ Power-up This bit powers-up the reference bias for the MIPI D-PHY


\
\ @brief DSI D-PHY clock band control register
\ Address offset: 0xC04
\ Reset value: 0x00000000
\

$000000f8 constant DSI_DSI_DPCBCR_BC                                \ Band control This field selects the frequency band used by the D-PHY. Others: Reserved


\
\ @brief DSI D-PHY clock skew rate control register
\ Address offset: 0xC34
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_DPCSRCR_SRC                              \ Slew rate control This field selects the slew rate for HS-TX speed. Others: Reserved


\
\ @brief DSI D-PHY data lane 0 band control register
\ Address offset: 0xC70
\ Reset value: 0x00000000
\

$0000001f constant DSI_DSI_DPDL0BCR_BC                              \ Band control This field selects the frequency band used by the D-PHY. Others: Reserved


\
\ @brief DSI D-PHY data lane 0 skew rate control register
\ Address offset: 0xCA0
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_DPDL0SRCR_SRC                            \ Slew rate control This field selects the slew rate for HS-TX speed. Others: Reserved


\
\ @brief DSI D-PHY data lane 1 band control register
\ Address offset: 0xD08
\ Reset value: 0x00000000
\

$0000001f constant DSI_DSI_DPDL1BCR_BC                              \ Band control This field selects the frequency band used by the D-PHY. Others: Reserved


\
\ @brief DSI D-PHY data lane 1 skew rate control register
\ Address offset: 0xD38
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_DPDL1SRCR_SRC                            \ Slew rate control This field selects the slew rate for HS-TX speed. Others: Reserved


\
\ @brief DSI
\
$40016c00 constant DSI_DSI_VR     \ offset: 0x00 : DSI Host version register
$40016c04 constant DSI_DSI_CR     \ offset: 0x04 : DSI Host control register
$40016c08 constant DSI_DSI_CCR    \ offset: 0x08 : DSI Host clock control register
$40016c0c constant DSI_DSI_LVCIDR  \ offset: 0x0C : DSI Host LTDC VCID register
$40016c10 constant DSI_DSI_LCOLCR  \ offset: 0x10 : DSI Host LTDC color coding register
$40016c14 constant DSI_DSI_LPCR   \ offset: 0x14 : DSI Host LTDC polarity configuration register
$40016c18 constant DSI_DSI_LPMCR  \ offset: 0x18 : DSI Host low-power mode configuration register
$40016c2c constant DSI_DSI_PCR    \ offset: 0x2C : DSI Host protocol configuration register
$40016c30 constant DSI_DSI_GVCIDR  \ offset: 0x30 : DSI Host generic VCID register
$40016c34 constant DSI_DSI_MCR    \ offset: 0x34 : DSI Host mode configuration register
$40016c38 constant DSI_DSI_VMCR   \ offset: 0x38 : DSI Host video mode configuration register
$40016c3c constant DSI_DSI_VPCR   \ offset: 0x3C : DSI Host video packet configuration register
$40016c40 constant DSI_DSI_VCCR   \ offset: 0x40 : DSI Host video chunks configuration register
$40016c44 constant DSI_DSI_VNPCR  \ offset: 0x44 : DSI Host video null packet configuration register
$40016c48 constant DSI_DSI_VHSACR  \ offset: 0x48 : DSI Host video HSA configuration register
$40016c4c constant DSI_DSI_VHBPCR  \ offset: 0x4C : DSI Host video HBP configuration register
$40016c50 constant DSI_DSI_VLCR   \ offset: 0x50 : DSI Host video line configuration register
$40016c54 constant DSI_DSI_VVSACR  \ offset: 0x54 : DSI Host video VSA configuration register
$40016c58 constant DSI_DSI_VVBPCR  \ offset: 0x58 : DSI Host video VBP configuration register
$40016c5c constant DSI_DSI_VVFPCR  \ offset: 0x5C : DSI Host video VFP configuration register
$40016c60 constant DSI_DSI_VVACR  \ offset: 0x60 : DSI Host video VA configuration register
$40016c64 constant DSI_DSI_LCCR   \ offset: 0x64 : DSI Host LTDC command configuration register
$40016c68 constant DSI_DSI_CMCR   \ offset: 0x68 : DSI Host command mode configuration register
$40016c6c constant DSI_DSI_GHCR   \ offset: 0x6C : DSI Host generic header configuration register
$40016c70 constant DSI_DSI_GPDR   \ offset: 0x70 : DSI Host generic payload data register
$40016c74 constant DSI_DSI_GPSR   \ offset: 0x74 : DSI Host generic packet status register
$40016c78 constant DSI_DSI_TCCR0  \ offset: 0x78 : DSI Host timeout counter configuration register 0
$40016c7c constant DSI_DSI_TCCR1  \ offset: 0x7C : DSI Host timeout counter configuration register 1
$40016c80 constant DSI_DSI_TCCR2  \ offset: 0x80 : DSI Host timeout counter configuration register 2
$40016c84 constant DSI_DSI_TCCR3  \ offset: 0x84 : DSI Host timeout counter configuration register 3
$40016c88 constant DSI_DSI_TCCR4  \ offset: 0x88 : DSI Host timeout counter configuration register 4
$40016c8c constant DSI_DSI_TCCR5  \ offset: 0x8C : DSI Host timeout counter configuration register 5
$40016c94 constant DSI_DSI_CLCR   \ offset: 0x94 : DSI Host clock lane configuration register
$40016c98 constant DSI_DSI_CLTCR  \ offset: 0x98 : DSI Host clock lane timer configuration register
$40016c9c constant DSI_DSI_DLTCR  \ offset: 0x9C : DSI Host data lane timer configuration register
$40016ca0 constant DSI_DSI_PCTLR  \ offset: 0xA0 : DSI Host PHY control register
$40016ca4 constant DSI_DSI_PCONFR  \ offset: 0xA4 : DSI Host PHY configuration register
$40016ca8 constant DSI_DSI_PUCR   \ offset: 0xA8 : DSI Host PHY ULPS control register
$40016cac constant DSI_DSI_PTTCR  \ offset: 0xAC : DSI Host PHY TX triggers configuration register
$40016cb0 constant DSI_DSI_PSR    \ offset: 0xB0 : DSI Host PHY status register
$40016cbc constant DSI_DSI_ISR0   \ offset: 0xBC : DSI Host interrupt and status register 0
$40016cc0 constant DSI_DSI_ISR1   \ offset: 0xC0 : DSI Host interrupt and status register 1
$40016cc4 constant DSI_DSI_IER0   \ offset: 0xC4 : DSI Host interrupt enable register 0
$40016cc8 constant DSI_DSI_IER1   \ offset: 0xC8 : DSI Host interrupt enable register 1
$40016cd8 constant DSI_DSI_FIR0   \ offset: 0xD8 : DSI Host force interrupt register 0
$40016cdc constant DSI_DSI_FIR1   \ offset: 0xDC : DSI Host force interrupt register 1
$40016cf4 constant DSI_DSI_DLTRCR  \ offset: 0xF4 : DSI Host data lane timer read configuration register
$40016d00 constant DSI_DSI_VSCR   \ offset: 0x100 : DSI Host video shadow control register
$40016d0c constant DSI_DSI_LCVCIDR  \ offset: 0x10C : DSI Host LTDC current VCID register
$40016d10 constant DSI_DSI_LCCCR  \ offset: 0x110 : DSI Host LTDC current color coding register
$40016d18 constant DSI_DSI_LPMCCR  \ offset: 0x118 : DSI Host low-power mode current configuration register
$40016d38 constant DSI_DSI_VMCCR  \ offset: 0x138 : DSI Host video mode current configuration register
$40016d3c constant DSI_DSI_VPCCR  \ offset: 0x13C : DSI Host video packet current configuration register
$40016d40 constant DSI_DSI_VCCCR  \ offset: 0x140 : DSI Host video chunks current configuration register
$40016d44 constant DSI_DSI_VNPCCR  \ offset: 0x144 : DSI Host video null packet current configuration register
$40016d48 constant DSI_DSI_VHSACCR  \ offset: 0x148 : DSI Host video HSA current configuration register
$40016d4c constant DSI_DSI_VHBPCCR  \ offset: 0x14C : DSI Host video HBP current configuration register
$40016d50 constant DSI_DSI_VLCCR  \ offset: 0x150 : DSI Host video line current configuration register
$40016d54 constant DSI_DSI_VVSACCR  \ offset: 0x154 : DSI Host video VSA current configuration register
$40016d58 constant DSI_DSI_VVBPCCR  \ offset: 0x158 : DSI Host video VBP current configuration register
$40016d5c constant DSI_DSI_VVFPCCR  \ offset: 0x15C : DSI Host video VFP current configuration register
$40016d60 constant DSI_DSI_VVACCR  \ offset: 0x160 : DSI Host video VA current configuration register
$40016d68 constant DSI_DSI_FBSR   \ offset: 0x168 : DSI Host FIFO and buffer status register
$40017000 constant DSI_DSI_WCFGR  \ offset: 0x400 : DSI Wrapper configuration register
$40017004 constant DSI_DSI_WCR    \ offset: 0x404 : DSI Wrapper control register
$40017008 constant DSI_DSI_WIER   \ offset: 0x408 : DSI Wrapper interrupt enable register
$4001700c constant DSI_DSI_WISR   \ offset: 0x40C : DSI Wrapper interrupt and status register
$40017010 constant DSI_DSI_WIFCR  \ offset: 0x410 : DSI Wrapper interrupt flag clear register
$40017018 constant DSI_DSI_WPCR0  \ offset: 0x418 : DSI Wrapper PHY configuration register 0
$40017030 constant DSI_DSI_WRPCR  \ offset: 0x430 : DSI Wrapper regulator and PLL control register
$40017408 constant DSI_DSI_BCFGR  \ offset: 0x808 : DSI bias configuration register
$40017804 constant DSI_DSI_DPCBCR  \ offset: 0xC04 : DSI D-PHY clock band control register
$40017834 constant DSI_DSI_DPCSRCR  \ offset: 0xC34 : DSI D-PHY clock skew rate control register
$40017870 constant DSI_DSI_DPDL0BCR  \ offset: 0xC70 : DSI D-PHY data lane 0 band control register
$400178a0 constant DSI_DSI_DPDL0SRCR  \ offset: 0xCA0 : DSI D-PHY data lane 0 skew rate control register
$40017908 constant DSI_DSI_DPDL1BCR  \ offset: 0xD08 : DSI D-PHY data lane 1 band control register
$40017938 constant DSI_DSI_DPDL1SRCR  \ offset: 0xD38 : DSI D-PHY data lane 1 skew rate control register

