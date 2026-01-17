\
\ @file dsihost.fs
\ @brief DSI Host
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DSIHOST_DEF

  [ifdef] DSIHOST_DSI_VR_DEF
    \
    \ @brief DSI Host version register
    \ Address offset: 0x00
    \ Reset value: 0x3133302A
    \
    $00 constant DSIHOST_VERSION                \ [0x00 : 32] Version of the DSI Host This read-only register contains the version of the DSI Host
  [then]


  [ifdef] DSIHOST_DSI_CR_DEF
    \
    \ @brief DSI Host control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_EN                     \ [0x00] Enable This bit configures the DSI Host in either power-up mode or to reset.
  [then]


  [ifdef] DSIHOST_DSI_CCR_DEF
    \
    \ @brief DSI Host clock control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TXECKDIV               \ [0x00 : 8] TX escape clock division This field indicates the division factor for the TX escape clock source (lanebyteclk). The values 0 and 1 stop the TX_ESC clock generation.
    $08 constant DSIHOST_TOCKDIV                \ [0x08 : 8] Timeout clock division This field indicates the division factor for the timeout clock used as the timing unit in the configuration of HS to LP and LP to HS transition error.
  [then]


  [ifdef] DSIHOST_DSI_LVCIDR_DEF
    \
    \ @brief DSI Host LTDC VCID register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VCID                   \ [0x00 : 2] Virtual channel ID These bits configure the virtual channel ID for the LTDC interface traffic.
  [then]


  [ifdef] DSIHOST_DSI_LCOLCR_DEF
    \
    \ @brief DSI Host LTDC color coding register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_COLC                   \ [0x00 : 4] Color coding This field configures the DPI color coding. Others: Reserved
    $08 constant DSIHOST_LPE                    \ [0x08] Loosely packet enable This bit enables the loosely packed variant to 18-bit configuration
  [then]


  [ifdef] DSIHOST_DSI_LPCR_DEF
    \
    \ @brief DSI Host LTDC polarity configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_DEP                    \ [0x00] Data enable polarity This bit configures the polarity of data enable pin.
    $01 constant DSIHOST_VSP                    \ [0x01] VSYNC polarity This bit configures the polarity of VSYNC pin.
    $02 constant DSIHOST_HSP                    \ [0x02] HSYNC polarity This bit configures the polarity of HSYNC pin.
  [then]


  [ifdef] DSIHOST_DSI_LPMCR_DEF
    \
    \ @brief DSI Host low-power mode configuration register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VLPSIZE                \ [0x00 : 8] VACT largest packet size This field is used for the transmission of commands in low-power mode. It defines the size, in bytes, of the largest packet that can fit in a line during VACT regions.
    $10 constant DSIHOST_LPSIZE                 \ [0x10 : 8] Largest packet size This field is used for the transmission of commands in low-power mode. It defines the size, in bytes, of the largest packet that can fit in a line during VSA, VBP and VFP regions.
  [then]


  [ifdef] DSIHOST_DSI_PCR_DEF
    \
    \ @brief DSI Host protocol configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_ETTXE                  \ [0x00] EoTp transmission enable This bit enables the EoTP transmission.
    $01 constant DSIHOST_ETRXE                  \ [0x01] EoTp reception enable This bit enables the EoTp reception.
    $02 constant DSIHOST_BTAE                   \ [0x02] Bus-turn-around enable This bit enables the bus-turn-around (BTA) request.
    $03 constant DSIHOST_ECCRXE                 \ [0x03] ECC reception enable This bit enables the ECC reception, error correction and reporting.
    $04 constant DSIHOST_CRCRXE                 \ [0x04] CRC reception enable This bit enables the CRC reception and error reporting.
  [then]


  [ifdef] DSIHOST_DSI_GVCIDR_DEF
    \
    \ @brief DSI Host generic VCID register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VCID                   \ [0x00 : 2] Virtual channel ID This field indicates the generic interface read-back virtual channel identification.
  [then]


  [ifdef] DSIHOST_DSI_MCR_DEF
    \
    \ @brief DSI Host mode configuration register
    \ Address offset: 0x34
    \ Reset value: 0x00000001
    \
    $00 constant DSIHOST_CMDM                   \ [0x00] Command mode This bit configures the DSI Host in either video or command mode.
  [then]


  [ifdef] DSIHOST_DSI_VMCR_DEF
    \
    \ @brief DSI Host video mode configuration register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VMT                    \ [0x00 : 2] Video mode type This field configures the video mode transmission type : 1x: Burst mode
    $08 constant DSIHOST_LPVSAE                 \ [0x08] Low-power vertical sync active enable This bit enables to return to low-power inside the vertical sync time (VSA) period when timing allows.
    $09 constant DSIHOST_LPVBPE                 \ [0x09] Low-power vertical back-porch enable This bit enables to return to low-power inside the vertical back-porch (VBP) period when timing allows.
    $0a constant DSIHOST_LPVFPE                 \ [0x0a] Low-power vertical front-porch enable This bit enables to return to low-power inside the vertical front-porch (VFP) period when timing allows.
    $0b constant DSIHOST_LPVAE                  \ [0x0b] Low-power vertical active enable This bit enables to return to low-power inside the vertical active (VACT) period when timing allows.
    $0c constant DSIHOST_LPHBPE                 \ [0x0c] Low-power horizontal back-porch enable This bit enables the return to low-power inside the horizontal back-porch (HBP) period when timing allows.
    $0d constant DSIHOST_LPHFPE                 \ [0x0d] Low-power horizontal front-porch enable This bit enables the return to low-power inside the horizontal front-porch (HFP) period when timing allows.
    $0e constant DSIHOST_FBTAAE                 \ [0x0e] Frame bus-turn-around acknowledge enable This bit enables the request for an acknowledge response at the end of a frame.
    $0f constant DSIHOST_LPCE                   \ [0x0f] Low-power command enable This bit enables the command transmission only in low-power mode.
    $10 constant DSIHOST_PGE                    \ [0x10] Pattern generator enable This bit enables the video mode pattern generator.
    $14 constant DSIHOST_PGM                    \ [0x14] Pattern generator mode This bit configures the pattern generator mode.
    $18 constant DSIHOST_PGO                    \ [0x18] Pattern generator orientation This bit configures the color bar orientation.
  [then]


  [ifdef] DSIHOST_DSI_VPCR_DEF
    \
    \ @brief DSI Host video packet configuration register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VPSIZE                 \ [0x00 : 14] Video packet size This field configures the number of pixels in a single video packet. For 18-bit not loosely packed data types, this number must be a multiple of 4. For YCbCr data types, it must be a multiple of 2 as described in the DSI specification.
  [then]


  [ifdef] DSIHOST_DSI_VCCR_DEF
    \
    \ @brief DSI Host video chunks configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_NUMC                   \ [0x00 : 13] Number of chunks This register configures the number of chunks to be transmitted during a line period (a chunk consists of a video packet and a null packet). If set to 0 or 1, the video line is transmitted in a single packet. If set to 1, the packet is part of a chunk, so a null packet follows it if NPSIZE > 0. Otherwise, multiple chunks are used to transmit each video line.
  [then]


  [ifdef] DSIHOST_DSI_VNPCR_DEF
    \
    \ @brief DSI Host video null packet configuration register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_NPSIZE                 \ [0x00 : 13] Null packet size This field configures the number of bytes inside a null packet. Setting to 0 disables the null packets.
  [then]


  [ifdef] DSIHOST_DSI_VHSACR_DEF
    \
    \ @brief DSI Host video HSA configuration register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HSA                    \ [0x00 : 12] Horizontal synchronism active duration This fields configures the horizontal synchronism active period in lane byte clock cycles.
  [then]


  [ifdef] DSIHOST_DSI_VHBPCR_DEF
    \
    \ @brief DSI Host video HBP configuration register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HBP                    \ [0x00 : 12] Horizontal back-porch duration This fields configures the horizontal back-porch period in lane byte clock cycles.
  [then]


  [ifdef] DSIHOST_DSI_VLCR_DEF
    \
    \ @brief DSI Host video line configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HLINE                  \ [0x00 : 15] Horizontal line duration This fields configures the total of the horizontal line period (HSA+HBP+HACT+HFP) counted in lane byte clock cycles.
  [then]


  [ifdef] DSIHOST_DSI_VVSACR_DEF
    \
    \ @brief DSI Host video VSA configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VSA                    \ [0x00 : 10] Vertical synchronism active duration This fields configures the vertical synchronism active period measured in number of horizontal lines.
  [then]


  [ifdef] DSIHOST_DSI_VVBPCR_DEF
    \
    \ @brief DSI Host video VBP configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VBP                    \ [0x00 : 10] Vertical back-porch duration This fields configures the vertical back-porch period measured in number of horizontal lines.
  [then]


  [ifdef] DSIHOST_DSI_VVFPCR_DEF
    \
    \ @brief DSI Host video VFP configuration register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VFP                    \ [0x00 : 10] Vertical front-porch duration This fields configures the vertical front-porch period measured in number of horizontal lines.
  [then]


  [ifdef] DSIHOST_DSI_VVACR_DEF
    \
    \ @brief DSI Host video VA configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VA                     \ [0x00 : 14] Vertical active duration This fields configures the vertical active period measured in number of horizontal lines.
  [then]


  [ifdef] DSIHOST_DSI_LCCR_DEF
    \
    \ @brief DSI Host LTDC command configuration register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_CMDSIZE                \ [0x00 : 16] Command size This field configures the maximum allowed size for an LTDC write memory command, measured in pixels. Automatic partitioning of data obtained from LTDC is permanently enabled.
  [then]


  [ifdef] DSIHOST_DSI_CMCR_DEF
    \
    \ @brief DSI Host command mode configuration register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TEARE                  \ [0x00] Tearing effect acknowledge request enable This bit enables the tearing effect acknowledge request:
    $01 constant DSIHOST_ARE                    \ [0x01] Acknowledge request enable This bit enables the acknowledge request after each packet transmission:
    $08 constant DSIHOST_GSW0TX                 \ [0x08] Generic short write zero parameters transmission This bit configures the generic short write packet with zero parameters command transmission type:
    $09 constant DSIHOST_GSW1TX                 \ [0x09] Generic short write one parameters transmission This bit configures the generic short write packet with one parameters command transmission type:
    $0a constant DSIHOST_GSW2TX                 \ [0x0a] Generic short write two parameters transmission This bit configures the generic short write packet with two parameters command transmission type:
    $0b constant DSIHOST_GSR0TX                 \ [0x0b] Generic short read zero parameters transmission This bit configures the generic short read packet with zero parameters command transmission type:
    $0c constant DSIHOST_GSR1TX                 \ [0x0c] Generic short read one parameters transmission This bit configures the generic short read packet with one parameters command transmission type:
    $0d constant DSIHOST_GSR2TX                 \ [0x0d] Generic short read two parameters transmission This bit configures the generic short read packet with two parameters command transmission type:
    $0e constant DSIHOST_GLWTX                  \ [0x0e] Generic long write transmission This bit configures the generic long write packet command transmission type :
    $10 constant DSIHOST_DSW0TX                 \ [0x10] DCS short write zero parameter transmission This bit configures the DCS short write packet with zero parameter command transmission type:
    $11 constant DSIHOST_DSW1TX                 \ [0x11] DCS short read one parameter transmission This bit configures the DCS short read packet with one parameter command transmission type:
    $12 constant DSIHOST_DSR0TX                 \ [0x12] DCS short read zero parameter transmission This bit configures the DCS short read packet with zero parameter command transmission type:
    $13 constant DSIHOST_DLWTX                  \ [0x13] DCS long write transmission This bit configures the DCS long write packet command transmission type:
    $18 constant DSIHOST_MRDPS                  \ [0x18] Maximum read packet size This bit configures the maximum read packet size command transmission type:
  [then]


  [ifdef] DSIHOST_DSI_GHCR_DEF
    \
    \ @brief DSI Host generic header configuration register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_DT                     \ [0x00 : 6] Type This field configures the packet data type of the header packet.
    $06 constant DSIHOST_VCID                   \ [0x06 : 2] Channel This field configures the virtual channel ID of the header packet.
    $08 constant DSIHOST_WCLSB                  \ [0x08 : 8] WordCount LSB This field configures the less significant byte of the header packet word count for long packets, or data 0 for short packets.
    $10 constant DSIHOST_WCMSB                  \ [0x10 : 8] WordCount MSB This field configures the most significant byte of the header packet word count for long packets, or data 1 for short packets.
  [then]


  [ifdef] DSIHOST_DSI_GPDR_DEF
    \
    \ @brief DSI Host generic payload data register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_DATA1                  \ [0x00 : 8] Payload byte 1 This field indicates the byte 1 of the packet payload.
    $08 constant DSIHOST_DATA2                  \ [0x08 : 8] Payload byte 2 This field indicates the byte 2 of the packet payload.
    $10 constant DSIHOST_DATA3                  \ [0x10 : 8] Payload byte 3 This field indicates the byte 3 of the packet payload.
    $18 constant DSIHOST_DATA4                  \ [0x18 : 8] Payload byte 4 This field indicates the byte 4 of the packet payload.
  [then]


  [ifdef] DSIHOST_DSI_GPSR_DEF
    \
    \ @brief DSI Host generic packet status register
    \ Address offset: 0x74
    \ Reset value: 0x00000015
    \
    $00 constant DSIHOST_CMDFE                  \ [0x00] Command FIFO empty This bit indicates the empty status of the generic command FIFO:
    $01 constant DSIHOST_CMDFF                  \ [0x01] Command FIFO full This bit indicates the full status of the generic command FIFO:
    $02 constant DSIHOST_PWRFE                  \ [0x02] Payload write FIFO empty This bit indicates the empty status of the generic write payload FIFO:
    $03 constant DSIHOST_PWRFF                  \ [0x03] Payload write FIFO full This bit indicates the full status of the generic write payload FIFO:
    $04 constant DSIHOST_PRDFE                  \ [0x04] Payload read FIFO empty This bit indicates the empty status of the generic read payload FIFO:
    $05 constant DSIHOST_PRDFF                  \ [0x05] Payload read FIFO full This bit indicates the full status of the generic read payload FIFO:
    $06 constant DSIHOST_RCB                    \ [0x06] Read command busy This bit is set when a read command is issued and cleared when the entire response is stored in the FIFO:
  [then]


  [ifdef] DSIHOST_DSI_TCCR0_DEF
    \
    \ @brief DSI Host timeout counter configuration register 0
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_LPRX_TOCNT             \ [0x00 : 16] Low-power reception timeout counter This field configures the timeout counter that triggers a low-power reception timeout contention detection (measured in TOCKDIV cycles).
    $10 constant DSIHOST_HSTX_TOCNT             \ [0x10 : 16] High-speed transmission timeout counter This field configures the timeout counter that triggers a high-speed transmission timeout contention detection (measured in TOCKDIV cycles).
  [then]


  [ifdef] DSIHOST_DSI_TCCR1_DEF
    \
    \ @brief DSI Host timeout counter configuration register 1
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HSRD_TOCNT             \ [0x00 : 16] High-speed read timeout counter This field sets a period for which the DSI Host keeps the link still, after sending a high-speed read operation. This period is measured in cycles of lanebyteclk. The counting starts when the D-PHY enters the Stop state and causes no interrupts.
  [then]


  [ifdef] DSIHOST_DSI_TCCR2_DEF
    \
    \ @brief DSI Host timeout counter configuration register 2
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_LPRD_TOCNT             \ [0x00 : 16] Low-power read timeout counter This field sets a period for which the DSI Host keeps the link still, after sending a low-power read operation. This period is measured in cycles of lanebyteclk. The counting starts when the D-PHY enters the Stop state and causes no interrupts.
  [then]


  [ifdef] DSIHOST_DSI_TCCR3_DEF
    \
    \ @brief DSI Host timeout counter configuration register 3
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HSWR_TOCNT             \ [0x00 : 16] High-speed write timeout counter This field sets a period for which the DSI Host keeps the link inactive after sending a high-speed write operation. This period is measured in cycles of lanebyteclk. The counting starts when the D-PHY enters the Stop state and causes no interrupts.
    $18 constant DSIHOST_PM                     \ [0x18] Presp mode When set to 1, this bit ensures that the peripheral response timeout caused by HSWR_TOCNT is used only once per LTDC frame in command mode, when both the following conditions are met: dpivsync_edpiwms has risen and fallen. Packets originated from LTDC in command mode have been transmitted and its FIFO is empty again. In this scenario no non-LTDC command requests are sent to the D-PHY, even if there is traffic from generic interface ready to be sent, making it return to stop state. When it does so, PRESP_TO counter is activated and only when it finishes does the controller send any other traffic that is ready.
  [then]


  [ifdef] DSIHOST_DSI_TCCR4_DEF
    \
    \ @brief DSI Host timeout counter configuration register 4
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_LPWR_TOCNT             \ [0x00 : 16] Low-power write timeout counter This field sets a period for which the DSI Host keeps the link still, after sending a low-power write operation. This period is measured in cycles of lanebyteclk. The counting starts when the D-PHY enters the Stop state and causes no interrupts.
  [then]


  [ifdef] DSIHOST_DSI_TCCR5_DEF
    \
    \ @brief DSI Host timeout counter configuration register 5
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_BTA_TOCNT              \ [0x00 : 16] Bus-turn-around timeout counter This field sets a period for which the DSI Host keeps the link still, after completing a bus-turn-around. This period is measured in cycles of lanebyteclk. The counting starts when the D-PHY enters the Stop state and causes no interrupts.
  [then]


  [ifdef] DSIHOST_DSI_CLCR_DEF
    \
    \ @brief DSI Host clock lane configuration register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_DPCC                   \ [0x00] D-PHY clock control This bit controls the D-PHY clock state:
    $01 constant DSIHOST_ACR                    \ [0x01] Automatic clock lane control This bit enables the automatic mechanism to stop providing clock in the clock lane when time allows.
  [then]


  [ifdef] DSIHOST_DSI_CLTCR_DEF
    \
    \ @brief DSI Host clock lane timer configuration register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_LP2HS_TIME             \ [0x00 : 10] Low-power to high-speed time This field configures the maximum time that the D-PHY clock lane takes to go from low power to high-speed transmission measured in lane byte clock cycles.
    $10 constant DSIHOST_HS2LP_TIME             \ [0x10 : 10] High-speed to low-power time This field configures the maximum time that the D-PHY clock lane takes to go from high speed to low-power transmission measured in lane byte clock cycles.
  [then]


  [ifdef] DSIHOST_DSI_DLTCR_DEF
    \
    \ @brief DSI Host data lane timer configuration register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_MRD_TIME               \ [0x00 : 15] Maximum read time This field configures the maximum time required to perform a read command in lane byte clock cycles. This register can only be modified when no read command is in progress.
    $10 constant DSIHOST_LP2HS_TIME             \ [0x10 : 8] Low-power to high-speed time This field configures the maximum time that the D-PHY data lanes take to go from low-power to high-speed transmission measured in lane byte clock cycles.
    $18 constant DSIHOST_HS2LP_TIME             \ [0x18 : 8] High-speed to low-power time This field configures the maximum time that the D-PHY data lanes take to go from high-speed to low-power transmission measured in lane byte clock cycles.
  [then]


  [ifdef] DSIHOST_DSI_PCTLR_DEF
    \
    \ @brief DSI Host PHY control register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $01 constant DSIHOST_DEN                    \ [0x01] Digital enable When set to 0, this bit places the digital section of the D-PHY in the reset state
    $02 constant DSIHOST_CKE                    \ [0x02] Clock enable This bit enables the D-PHY clock lane module:
  [then]


  [ifdef] DSIHOST_DSI_PCONFR_DEF
    \
    \ @brief DSI Host PHY configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000001
    \
    $00 constant DSIHOST_NL                     \ [0x00 : 2] Number of lanes This field configures the number of active data lanes: Others: Reserved
    $08 constant DSIHOST_SW_TIME                \ [0x08 : 8] Stop wait time This field configures the minimum wait period to request a high-speed transmission after the Stop state.
  [then]


  [ifdef] DSIHOST_DSI_PUCR_DEF
    \
    \ @brief DSI Host PHY ULPS control register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_URCL                   \ [0x00] ULPS request on clock lane ULPS mode request on clock lane.
    $01 constant DSIHOST_UECL                   \ [0x01] ULPS exit on clock lane ULPS mode exit on clock lane.
    $02 constant DSIHOST_URDL                   \ [0x02] ULPS request on data lane ULPS mode request on all active data lanes.
    $03 constant DSIHOST_UEDL                   \ [0x03] ULPS exit on data lane ULPS mode exit on all active data lanes.
  [then]


  [ifdef] DSIHOST_DSI_PTTCR_DEF
    \
    \ @brief DSI Host PHY TX triggers configuration register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TX_TRIG                \ [0x00 : 4] Transmission trigger Escape mode transmit trigger 0-3. Only one bit of TX_TRIG is asserted at any given time.
  [then]


  [ifdef] DSIHOST_DSI_PSR_DEF
    \
    \ @brief DSI Host PHY status register
    \ Address offset: 0xB0
    \ Reset value: 0x00001528
    \
    $01 constant DSIHOST_PD                     \ [0x01] PHY direction This bit indicates the status of phydirection D-PHY signal.
    $02 constant DSIHOST_PSSC                   \ [0x02] PHY stop state clock lane This bit indicates the status of phystopstateclklane D-PHY signal.
    $03 constant DSIHOST_UANC                   \ [0x03] ULPS active not clock lane This bit indicates the status of ulpsactivenotclklane D-PHY signal.
    $04 constant DSIHOST_PSS0                   \ [0x04] PHY stop state lane 0 This bit indicates the status of phystopstate0lane D-PHY signal.
    $05 constant DSIHOST_UAN0                   \ [0x05] ULPS active not lane 1 This bit indicates the status of ulpsactivenot0lane D-PHY signal.
    $06 constant DSIHOST_RUE0                   \ [0x06] RX ULPS escape lane 0 This bit indicates the status of rxulpsesc0lane D-PHY signal.
    $07 constant DSIHOST_PSS1                   \ [0x07] PHY stop state lane 1 This bit indicates the status of phystopstate1lane D-PHY signal.
    $08 constant DSIHOST_UAN1                   \ [0x08] ULPS active not lane 1 This bit indicates the status of ulpsactivenot1lane D-PHY signal.
  [then]


  [ifdef] DSIHOST_DSI_ISR0_DEF
    \
    \ @brief DSI Host interrupt and status register 0
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_AE0                    \ [0x00] Acknowledge error 0 This bit retrieves the SoT error from the acknowledge error report.
    $01 constant DSIHOST_AE1                    \ [0x01] Acknowledge error 1 This bit retrieves the SoT sync error from the acknowledge error report.
    $02 constant DSIHOST_AE2                    \ [0x02] Acknowledge error 2 This bit retrieves the EoT sync error from the acknowledge error report.
    $03 constant DSIHOST_AE3                    \ [0x03] Acknowledge error 3 This bit retrieves the escape mode entry command error from the acknowledge error report.
    $04 constant DSIHOST_AE4                    \ [0x04] Acknowledge error 4 This bit retrieves the LP transmit sync error from the acknowledge error report.
    $05 constant DSIHOST_AE5                    \ [0x05] Acknowledge error 5 This bit retrieves the peripheral timeout error from the acknowledge error report.
    $06 constant DSIHOST_AE6                    \ [0x06] Acknowledge error 6 This bit retrieves the false control error from the acknowledge error report.
    $07 constant DSIHOST_AE7                    \ [0x07] Acknowledge error 7 This bit retrieves the reserved (specific to the device) from the acknowledge error report.
    $08 constant DSIHOST_AE8                    \ [0x08] Acknowledge error 8 This bit retrieves the ECC error, single-bit (detected and corrected) from the acknowledge error report.
    $09 constant DSIHOST_AE9                    \ [0x09] Acknowledge error 9 This bit retrieves the ECC error, multi-bit (detected, not corrected) from the acknowledge error report.
    $0a constant DSIHOST_AE10                   \ [0x0a] Acknowledge error 10 This bit retrieves the checksum error (long packet only) from the acknowledge error report.
    $0b constant DSIHOST_AE11                   \ [0x0b] Acknowledge error 11 This bit retrieves the not recognized DSI data type from the acknowledge error report.
    $0c constant DSIHOST_AE12                   \ [0x0c] Acknowledge error 12 This bit retrieves the DSI VC ID Invalid from the acknowledge error report.
    $0d constant DSIHOST_AE13                   \ [0x0d] Acknowledge error 13 This bit retrieves the invalid transmission length from the acknowledge error report.
    $0e constant DSIHOST_AE14                   \ [0x0e] Acknowledge error 14 This bit retrieves the reserved (specific to the device) from the acknowledge error report.
    $0f constant DSIHOST_AE15                   \ [0x0f] Acknowledge error 15 This bit retrieves the DSI protocol violation from the acknowledge error report.
    $10 constant DSIHOST_PE0                    \ [0x10] PHY error 0 This bit indicates the ErrEsc escape entry error from lane 0.
    $11 constant DSIHOST_PE1                    \ [0x11] PHY error 1 This bit indicates the ErrSyncEsc low-power transmission synchronization error from lane 0.
    $12 constant DSIHOST_PE2                    \ [0x12] PHY error 2 This bit indicates the ErrControl error from lane 0.
    $13 constant DSIHOST_PE3                    \ [0x13] PHY error 3 This bit indicates the LP0 contention error ErrContentionLP0 from lane 0.
    $14 constant DSIHOST_PE4                    \ [0x14] PHY error 4 This bit indicates the LP1 contention error ErrContentionLP1 from lane 0.
  [then]


  [ifdef] DSIHOST_DSI_ISR1_DEF
    \
    \ @brief DSI Host interrupt and status register 1
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TOHSTX                 \ [0x00] Timeout high-speed transmission This bit indicates that the high-speed transmission timeout counter reached the end and contention is detected.
    $01 constant DSIHOST_TOLPRX                 \ [0x01] Timeout low-power reception This bit indicates that the low-power reception timeout counter reached the end and contention is detected.
    $02 constant DSIHOST_ECCSE                  \ [0x02] ECC single-bit error This bit indicates that the ECC single error is detected and corrected in a received packet.
    $03 constant DSIHOST_ECCME                  \ [0x03] ECC multi-bit error This bit indicates that the ECC multiple error is detected in a received packet.
    $04 constant DSIHOST_CRCE                   \ [0x04] CRC error This bit indicates that the CRC error is detected in the received packet payload.
    $05 constant DSIHOST_PSE                    \ [0x05] Packet size error This bit indicates that the packet size error is detected during the packet reception.
    $06 constant DSIHOST_EOTPE                  \ [0x06] EoTp error This bit indicates that the EoTp packet is not received at the end of the incoming peripheral transmission.
    $07 constant DSIHOST_LPWRE                  \ [0x07] LTDC payload write error This bit indicates that during a DPI pixel line storage, the payload FIFO becomes full and the data stored is corrupted.
    $08 constant DSIHOST_GCWRE                  \ [0x08] Generic command write error This bit indicates that the system tried to write a command through the generic interface and the FIFO is full. Therefore, the command is not written.
    $09 constant DSIHOST_GPWRE                  \ [0x09] Generic payload write error This bit indicates that the system tried to write a payload data through the generic interface and the FIFO is full. Therefore, the payload is not written.
    $0a constant DSIHOST_GPTXE                  \ [0x0a] Generic payload transmit error This bit indicates that during a generic interface packet build, the payload FIFO becomes empty and corrupt data is sent.
    $0b constant DSIHOST_GPRDE                  \ [0x0b] Generic payload read error This bit indicates that during a DCS read data, the payload FIFO becomes empty and the data sent to the interface is corrupted.
    $0c constant DSIHOST_GPRXE                  \ [0x0c] Generic payload receive error This bit indicates that during a generic interface packet read back, the payload FIFO becomes full and the received data is corrupted.
  [then]


  [ifdef] DSIHOST_DSI_IER0_DEF
    \
    \ @brief DSI Host interrupt enable register 0
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_AE0IE                  \ [0x00] Acknowledge error 0 interrupt enable This bit enables the interrupt generation on acknowledge error 0.
    $01 constant DSIHOST_AE1IE                  \ [0x01] Acknowledge error 1 interrupt enable This bit enables the interrupt generation on acknowledge error 1.
    $02 constant DSIHOST_AE2IE                  \ [0x02] Acknowledge error 2 interrupt enable This bit enables the interrupt generation on acknowledge error 2.
    $03 constant DSIHOST_AE3IE                  \ [0x03] Acknowledge error 3 interrupt enable This bit enables the interrupt generation on acknowledge error 3.
    $04 constant DSIHOST_AE4IE                  \ [0x04] Acknowledge error 4 interrupt enable This bit enables the interrupt generation on acknowledge error 4.
    $05 constant DSIHOST_AE5IE                  \ [0x05] Acknowledge error 5 interrupt enable This bit enables the interrupt generation on acknowledge error 5.
    $06 constant DSIHOST_AE6IE                  \ [0x06] Acknowledge error 6 interrupt enable This bit enables the interrupt generation on acknowledge error 6.
    $07 constant DSIHOST_AE7IE                  \ [0x07] Acknowledge error 7 interrupt enable This bit enables the interrupt generation on acknowledge error 7.
    $08 constant DSIHOST_AE8IE                  \ [0x08] Acknowledge error 8 interrupt enable This bit enables the interrupt generation on acknowledge error 8.
    $09 constant DSIHOST_AE9IE                  \ [0x09] Acknowledge error 9 interrupt enable This bit enables the interrupt generation on acknowledge error 9.
    $0a constant DSIHOST_AE10IE                 \ [0x0a] Acknowledge error 10 interrupt enable This bit enables the interrupt generation on acknowledge error 10.
    $0b constant DSIHOST_AE11IE                 \ [0x0b] Acknowledge error 11 interrupt enable This bit enables the interrupt generation on acknowledge error 11.
    $0c constant DSIHOST_AE12IE                 \ [0x0c] Acknowledge error 12 interrupt enable This bit enables the interrupt generation on acknowledge error 12.
    $0d constant DSIHOST_AE13IE                 \ [0x0d] Acknowledge error 13 interrupt enable This bit enables the interrupt generation on acknowledge error 13.
    $0e constant DSIHOST_AE14IE                 \ [0x0e] Acknowledge error 14 interrupt enable This bit enables the interrupt generation on acknowledge error 14.
    $0f constant DSIHOST_AE15IE                 \ [0x0f] Acknowledge error 15 interrupt enable This bit enables the interrupt generation on acknowledge error 15.
    $10 constant DSIHOST_PE0IE                  \ [0x10] PHY error 0 interrupt enable This bit enables the interrupt generation on PHY error 0.
    $11 constant DSIHOST_PE1IE                  \ [0x11] PHY error 1 interrupt enable This bit enables the interrupt generation on PHY error 1.
    $12 constant DSIHOST_PE2IE                  \ [0x12] PHY error 2 interrupt enable This bit enables the interrupt generation on PHY error 2.
    $13 constant DSIHOST_PE3IE                  \ [0x13] PHY error 3 interrupt enable This bit enables the interrupt generation on PHY error 4.
    $14 constant DSIHOST_PE4IE                  \ [0x14] PHY error 4 interrupt enable This bit enables the interrupt generation on PHY error 4.
  [then]


  [ifdef] DSIHOST_DSI_IER1_DEF
    \
    \ @brief DSI Host interrupt enable register 1
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TOHSTXIE               \ [0x00] Timeout high-speed transmission interrupt enable This bit enables the interrupt generation on timeout high-speed transmission .
    $01 constant DSIHOST_TOLPRXIE               \ [0x01] Timeout low-power reception interrupt enable This bit enables the interrupt generation on timeout low-power reception.
    $02 constant DSIHOST_ECCSEIE                \ [0x02] ECC single-bit error interrupt enable This bit enables the interrupt generation on ECC single-bit error.
    $03 constant DSIHOST_ECCMEIE                \ [0x03] ECC multi-bit error interrupt enable This bit enables the interrupt generation on ECC multi-bit error.
    $04 constant DSIHOST_CRCEIE                 \ [0x04] CRC error interrupt enable This bit enables the interrupt generation on CRC error.
    $05 constant DSIHOST_PSEIE                  \ [0x05] Packet size error interrupt enable This bit enables the interrupt generation on packet size error.
    $06 constant DSIHOST_EOTPEIE                \ [0x06] EoTp error interrupt enable This bit enables the interrupt generation on EoTp error.
    $07 constant DSIHOST_LPWREIE                \ [0x07] LTDC payload write error interrupt enable This bit enables the interrupt generation on LTDC payload write error.
    $08 constant DSIHOST_GCWREIE                \ [0x08] Generic command write error interrupt enable This bit enables the interrupt generation on generic command write error.
    $09 constant DSIHOST_GPWREIE                \ [0x09] Generic payload write error interrupt enable This bit enables the interrupt generation on generic payload write error.
    $0a constant DSIHOST_GPTXEIE                \ [0x0a] Generic payload transmit error interrupt enable This bit enables the interrupt generation on generic payload transmit error.
    $0b constant DSIHOST_GPRDEIE                \ [0x0b] Generic payload read error interrupt enable This bit enables the interrupt generation on generic payload read error.
    $0c constant DSIHOST_GPRXEIE                \ [0x0c] Generic payload receive error interrupt enable This bit enables the interrupt generation on generic payload receive error.
  [then]


  [ifdef] DSIHOST_DSI_FIR0_DEF
    \
    \ @brief DSI Host force interrupt register 0
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_FAE0                   \ [0x00] Force acknowledge error 0 Writing one to this bit forces an acknowledge error 0.
    $01 constant DSIHOST_FAE1                   \ [0x01] Force acknowledge error 1 Writing one to this bit forces an acknowledge error 1.
    $02 constant DSIHOST_FAE2                   \ [0x02] Force acknowledge error 2 Writing one to this bit forces an acknowledge error 2.
    $03 constant DSIHOST_FAE3                   \ [0x03] Force acknowledge error 3 Writing one to this bit forces an acknowledge error 3.
    $04 constant DSIHOST_FAE4                   \ [0x04] Force acknowledge error 4 Writing one to this bit forces an acknowledge error 4.
    $05 constant DSIHOST_FAE5                   \ [0x05] Force acknowledge error 5 Writing one to this bit forces an acknowledge error 5.
    $06 constant DSIHOST_FAE6                   \ [0x06] Force acknowledge error 6 Writing one to this bit forces an acknowledge error 6.
    $07 constant DSIHOST_FAE7                   \ [0x07] Force acknowledge error 7 Writing one to this bit forces an acknowledge error 7.
    $08 constant DSIHOST_FAE8                   \ [0x08] Force acknowledge error 8 Writing one to this bit forces an acknowledge error 8.
    $09 constant DSIHOST_FAE9                   \ [0x09] Force acknowledge error 9 Writing one to this bit forces an acknowledge error 9.
    $0a constant DSIHOST_FAE10                  \ [0x0a] Force acknowledge error 10 Writing one to this bit forces an acknowledge error 10.
    $0b constant DSIHOST_FAE11                  \ [0x0b] Force acknowledge error 11 Writing one to this bit forces an acknowledge error 11.
    $0c constant DSIHOST_FAE12                  \ [0x0c] Force acknowledge error 12 Writing one to this bit forces an acknowledge error 12.
    $0d constant DSIHOST_FAE13                  \ [0x0d] Force acknowledge error 13 Writing one to this bit forces an acknowledge error 13.
    $0e constant DSIHOST_FAE14                  \ [0x0e] Force acknowledge error 14 Writing one to this bit forces an acknowledge error 14.
    $0f constant DSIHOST_FAE15                  \ [0x0f] Force acknowledge error 15 Writing one to this bit forces an acknowledge error 15.
    $10 constant DSIHOST_FPE0                   \ [0x10] Force PHY error 0 Writing one to this bit forces a PHY error 0.
    $11 constant DSIHOST_FPE1                   \ [0x11] Force PHY error 1 Writing one to this bit forces a PHY error 1.
    $12 constant DSIHOST_FPE2                   \ [0x12] Force PHY error 2 Writing one to this bit forces a PHY error 2.
    $13 constant DSIHOST_FPE3                   \ [0x13] Force PHY error 3 Writing one to this bit forces a PHY error 3.
    $14 constant DSIHOST_FPE4                   \ [0x14] Force PHY error 4 Writing one to this bit forces a PHY error 4.
  [then]


  [ifdef] DSIHOST_DSI_FIR1_DEF
    \
    \ @brief DSI Host force interrupt register 1
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_FTOHSTX                \ [0x00] Force timeout high-speed transmission Writing one to this bit forces a timeout high-speed transmission.
    $01 constant DSIHOST_FTOLPRX                \ [0x01] Force timeout low-power reception Writing one to this bit forces a timeout low-power reception.
    $02 constant DSIHOST_FECCSE                 \ [0x02] Force ECC single-bit error Writing one to this bit forces a ECC single-bit error.
    $03 constant DSIHOST_FECCME                 \ [0x03] Force ECC multi-bit error Writing one to this bit forces a ECC multi-bit error.
    $04 constant DSIHOST_FCRCE                  \ [0x04] Force CRC error Writing one to this bit forces a CRC error.
    $05 constant DSIHOST_FPSE                   \ [0x05] Force packet size error Writing one to this bit forces a packet size error.
    $06 constant DSIHOST_FEOTPE                 \ [0x06] Force EoTp error Writing one to this bit forces a EoTp error.
    $07 constant DSIHOST_FLPWRE                 \ [0x07] Force LTDC payload write error Writing one to this bit forces a LTDC payload write error.
    $08 constant DSIHOST_FGCWRE                 \ [0x08] Force generic command write error Writing one to this bit forces a generic command write error.
    $09 constant DSIHOST_FGPWRE                 \ [0x09] Force generic payload write error Writing one to this bit forces a generic payload write error.
    $0a constant DSIHOST_FGPTXE                 \ [0x0a] Force generic payload transmit error Writing one to this bit forces a generic payload transmit error.
    $0b constant DSIHOST_FGPRDE                 \ [0x0b] Force generic payload read error Writing one to this bit forces a generic payload read error.
    $0c constant DSIHOST_FGPRXE                 \ [0x0c] Force generic payload receive error Writing one to this bit forces a generic payload receive error.
  [then]


  [ifdef] DSIHOST_DSI_VSCR_DEF
    \
    \ @brief DSI Host video shadow control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_EN                     \ [0x00] Enable When set to 1, DSI Host LTDC interface receives the active configuration from the auxiliary registers. When this bit is set along with the UR bit, the auxiliary registers are automatically updated.
    $08 constant DSIHOST_UR                     \ [0x08] Update register When set to 1, the LTDC registers are copied to the auxiliary registers. After copying, this bit is auto cleared.
  [then]


  [ifdef] DSIHOST_DSI_LCVCIDR_DEF
    \
    \ @brief DSI Host LTDC current VCID register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VCID                   \ [0x00 : 2] Virtual channel ID This field returns the virtual channel ID for the LTDC interface.
  [then]


  [ifdef] DSIHOST_DSI_LCCCR_DEF
    \
    \ @brief DSI Host LTDC current color coding register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_COLC                   \ [0x00 : 4] Color coding This field returns the current LTDC interface color coding. If LTDC interface in command mode is chosen and currently works in the command mode (CMDM=1), then 0110-1111: 24-bit
    $08 constant DSIHOST_LPE                    \ [0x08] Loosely packed enable This bit returns the current state of the loosely packed variant to 18-bit configurations.
  [then]


  [ifdef] DSIHOST_DSI_LPMCCR_DEF
    \
    \ @brief DSI Host low-power mode current configuration register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VLPSIZE                \ [0x00 : 8] VACT largest packet size This field returns the current size, in bytes, of the largest packet that can fit in a line during VACT regions, for the transmission of commands in low-power mode.
    $10 constant DSIHOST_LPSIZE                 \ [0x10 : 8] Largest packet size This field is returns the current size, in bytes, of the largest packet that can fit in a line during VSA, VBP and VFP regions, for the transmission of commands in low-power mode.
  [then]


  [ifdef] DSIHOST_DSI_VMCCR_DEF
    \
    \ @brief DSI Host video mode current configuration register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VMT                    \ [0x00 : 2] Video mode type This field returns the current video mode transmission type: 1x: Burst mode
    $02 constant DSIHOST_LPVSAE                 \ [0x02] Low-power vertical sync time enable This bit returns the current state of return to low-power inside the vertical sync time (VSA) period when timing allows.
    $03 constant DSIHOST_LPVBPE                 \ [0x03] Low-power vertical back-porch enable This bit returns the current state of return to low-power inside the vertical back-porch (VBP) period when timing allows.
    $04 constant DSIHOST_LPVFPE                 \ [0x04] Low-power vertical front-porch enable This bit returns the current state of return to low-power inside the vertical front-porch (VFP) period when timing allows.
    $05 constant DSIHOST_LPVAE                  \ [0x05] Low-power vertical active enable This bit returns the current state of return to low-power inside the vertical active (VACT) period when timing allows.
    $06 constant DSIHOST_LPHBPE                 \ [0x06] Low-power horizontal back-porch enable This bit returns the current state of return to low-power inside the horizontal back-porch (HBP) period when timing allows.
    $07 constant DSIHOST_LPHFE                  \ [0x07] Low-power horizontal front-porch enable This bit returns the current state of return to low-power inside the horizontal front-porch (HFP) period when timing allows.
    $08 constant DSIHOST_FBTAAE                 \ [0x08] Frame BTA acknowledge enable This bit returns the current state of request for an acknowledge response at the end of a frame.
    $09 constant DSIHOST_LPCE                   \ [0x09] Low-power command enable This bit returns the current command transmission state in low-power mode.
  [then]


  [ifdef] DSIHOST_DSI_VPCCR_DEF
    \
    \ @brief DSI Host video packet current configuration register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VPSIZE                 \ [0x00 : 14] Video packet size This field returns the number of pixels in a single video packet.
  [then]


  [ifdef] DSIHOST_DSI_VCCCR_DEF
    \
    \ @brief DSI Host video chunks current configuration register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_NUMC                   \ [0x00 : 13] Number of chunks This field returns the number of chunks being transmitted during a line period.
  [then]


  [ifdef] DSIHOST_DSI_VNPCCR_DEF
    \
    \ @brief DSI Host video null packet current configuration register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_NPSIZE                 \ [0x00 : 13] Null packet size This field returns the number of bytes inside a null packet.
  [then]


  [ifdef] DSIHOST_DSI_VHSACCR_DEF
    \
    \ @brief DSI Host video HSA current configuration register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HSA                    \ [0x00 : 12] Horizontal synchronism active duration This fields returns the horizontal synchronism active period in lane byte clock cycles.
  [then]


  [ifdef] DSIHOST_DSI_VHBPCCR_DEF
    \
    \ @brief DSI Host video HBP current configuration register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HBP                    \ [0x00 : 12] Horizontal back-porch duration This field returns the horizontal back-porch period in lane byte clock cycles.
  [then]


  [ifdef] DSIHOST_DSI_VLCCR_DEF
    \
    \ @brief DSI Host video line current configuration register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HLINE                  \ [0x00 : 15] Horizontal line duration This field returns the current total of the horizontal line period (HSA+HBP+HACT+HFP) counted in lane byte clock cycles.
  [then]


  [ifdef] DSIHOST_DSI_VVSACCR_DEF
    \
    \ @brief DSI Host video VSA current configuration register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VSA                    \ [0x00 : 10] Vertical synchronism active duration This field returns the current vertical synchronism active period measured in number of horizontal lines.
  [then]


  [ifdef] DSIHOST_DSI_VVBPCCR_DEF
    \
    \ @brief DSI Host video VBP current configuration register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VBP                    \ [0x00 : 10] Vertical back-porch duration This field returns the current vertical back-porch period measured in number of horizontal lines.
  [then]


  [ifdef] DSIHOST_DSI_VVFPCCR_DEF
    \
    \ @brief DSI Host video VFP current configuration register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VFP                    \ [0x00 : 10] Vertical front-porch duration This field returns the current vertical front-porch period measured in number of horizontal lines.
  [then]


  [ifdef] DSIHOST_DSI_VVACCR_DEF
    \
    \ @brief DSI Host video VA current configuration register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VA                     \ [0x00 : 14] Vertical active duration This field returns the current vertical active period measured in number of horizontal lines.
  [then]


  [ifdef] DSIHOST_DSI_WCFGR_DEF
    \
    \ @brief DSI Wrapper configuration register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_DSIM                   \ [0x00] DSI mode This bit selects the mode for the video transmission. This bit must only be changed when DSI Host is stopped (DSI_CR.EN = 0).
    $01 constant DSIHOST_COLMUX                 \ [0x01 : 3] Color multiplexing This bit selects the color multiplexing used by DSI Host. This field must only be changed when DSI is stopped (DSI_WCR.DSIEN = 0 and DSI_CR.EN=0).
    $04 constant DSIHOST_TESRC                  \ [0x04] TE source This bit selects the tearing effect (TE) source. This bit must only be changed when DSI Host is stopped (DSI_CR.EN = 0).
    $05 constant DSIHOST_TEPOL                  \ [0x05] TE polarity This bit selects the polarity of the external pin tearing effect (TE) source. This bit must only be changed when DSI Host is stopped (DSI_CR.EN = 0).
    $06 constant DSIHOST_AR                     \ [0x06] Automatic refresh This bit selects the refresh mode in DBI mode. This bit must only be changed when DSI Host is stopped (DSI_CR.EN = 0).
    $07 constant DSIHOST_VSPOL                  \ [0x07] VSync polarity This bit selects the VSync edge on which the LTDC is halted. This bit must only be changed when DSI is stopped (DSI_WCR.DSIEN = 0 and DSI_CR.EN=0).
  [then]


  [ifdef] DSIHOST_DSI_WCR_DEF
    \
    \ @brief DSI Wrapper control register
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_COLM                   \ [0x00] Color mode This bit controls the display color mode in video mode.
    $01 constant DSIHOST_SHTDN                  \ [0x01] Shutdown This bit controls the display shutdown in video mode.
    $02 constant DSIHOST_LTDCEN                 \ [0x02] LTDC enable This bit enables the LTDC for a frame transfer in adapted command mode.
    $03 constant DSIHOST_DSIEN                  \ [0x03] DSI enable This bit enables the DSI Wrapper.
  [then]


  [ifdef] DSIHOST_DSI_WIER_DEF
    \
    \ @brief DSI Wrapper interrupt enable register
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TEIE                   \ [0x00] Tearing effect interrupt enable This bit enables the tearing effect interrupt.
    $01 constant DSIHOST_ERIE                   \ [0x01] End of refresh interrupt enable This bit enables the end of refresh interrupt.
    $09 constant DSIHOST_PLLLIE                 \ [0x09] PLL lock interrupt enable This bit enables the PLL lock interrupt.
    $0a constant DSIHOST_PLLUIE                 \ [0x0a] PLL unlock interrupt enable This bit enables the PLL unlock interrupt.
    $0d constant DSIHOST_RRIE                   \ [0x0d] Regulator ready interrupt enable This bit enables the regulator ready interrupt.
  [then]


  [ifdef] DSIHOST_DSI_WISR_DEF
    \
    \ @brief DSI Wrapper interrupt and status register
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TEIF                   \ [0x00] Tearing effect interrupt flag This bit is set when a tearing effect event occurs.
    $01 constant DSIHOST_ERIF                   \ [0x01] End of refresh interrupt flag This bit is set when the transfer of a frame in adapted command mode is finished.
    $02 constant DSIHOST_BUSY                   \ [0x02] Busy flag This bit is set when the transfer of a frame in adapted command mode is ongoing.
    $08 constant DSIHOST_PLLLS                  \ [0x08] PLL lock status This bit is set when the PLL is locked and cleared when it is unlocked.
    $09 constant DSIHOST_PLLLIF                 \ [0x09] PLL lock interrupt flag This bit is set when the PLL becomes locked.
    $0a constant DSIHOST_PLLUIF                 \ [0x0a] PLL unlock interrupt flag This bit is set when the PLL becomes unlocked.
    $0c constant DSIHOST_RRS                    \ [0x0c] Regulator ready status This bit gives the status of the regulator.
    $0d constant DSIHOST_RRIF                   \ [0x0d] Regulator ready interrupt flag This bit is set when the regulator becomes ready.
  [then]


  [ifdef] DSIHOST_DSI_WIFCR_DEF
    \
    \ @brief DSI Wrapper interrupt flag clear register
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_CTEIF                  \ [0x00] Clear tearing effect interrupt flag Write 1 clears the TEIF flag in the DSI_WSR register.
    $01 constant DSIHOST_CERIF                  \ [0x01] Clear end of refresh interrupt flag Write 1 clears the ERIF flag in the DSI_WSR register.
    $09 constant DSIHOST_CPLLLIF                \ [0x09] Clear PLL lock interrupt flag Write 1 clears the PLLLIF flag in the DSI_WSR register.
    $0a constant DSIHOST_CPLLUIF                \ [0x0a] Clear PLL unlock interrupt flag Write 1 clears the PLLUIF flag in the DSI_WSR register.
    $0d constant DSIHOST_CRRIF                  \ [0x0d] Clear regulator ready interrupt flag Write 1 clears the RRIF flag in the DSI_WSR register.
  [then]


  [ifdef] DSIHOST_DSI_WPCR0_DEF
    \
    \ @brief DSI Wrapper PHY configuration register 0
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_UIX4                   \ [0x00 : 6] Unit interval multiplied by 4 This field defines the bit period in high-speed mode in unit of 0.25 ns. As an example, if the unit interval is 3 ns, a value of twelve (0x0C) must be driven to this input. This value is used to generate delays. If the period is not a multiple of 0.25 ns, the value driven must be rounded down. For example, a 600 Mbit/s link uses a unit interval of 1.667 ns, which, multiplied by four gives 6.667 ns. In this case a value of 6 (not 7) must be driven onto the ui_x4 input.
    $06 constant DSIHOST_SWCL                   \ [0x06] Swap clock lane pins This bit swaps the pins on clock lane.
    $07 constant DSIHOST_SWDL0                  \ [0x07] Swap data lane 0 pins This bit swaps the pins on data lane 0.
    $08 constant DSIHOST_SWDL1                  \ [0x08] Swap data lane 1 pins This bit swaps the pins on clock lane.
    $09 constant DSIHOST_HSICL                  \ [0x09] Invert high-speed data signal on clock lane This bit inverts the high-speed data signal on clock lane.
    $0a constant DSIHOST_HSIDL0                 \ [0x0a] Invert the high-speed data signal on data lane 0 This bit inverts the high-speed data signal on clock lane.
    $0b constant DSIHOST_HSIDL1                 \ [0x0b] Invert the high-speed data signal on data lane 1 This bit inverts the high-speed data signal on data lane 1.
    $0c constant DSIHOST_FTXSMCL                \ [0x0c] Force in TX Stop mode the clock lane This bit forces the clock lane in TX stop mode. It is used to initialize a lane module in transmit mode. It causes the lane module to immediately jump to transmit control mode and to begin transmitting a stop state (LP-11). It can be used to go back in TX mode after a wrong BTA sequence.
    $0d constant DSIHOST_FTXSMDL                \ [0x0d] Force in TX Stop mode the data lanes This bit forces the data lanes in TX stop mode. It is used to initialize a lane module in transmit mode. It causes the lane module to immediately jump to transmit control mode and to begin transmitting a stop state (LP-11). It can be used to go back in TX mode after a wrong BTA sequence.
    $0e constant DSIHOST_CDOFFDL                \ [0x0e] Contention detection OFF on data lanes When only forward escape mode is used, this signal can be made high to switch off the contention detector and reduce static power consumption.
    $10 constant DSIHOST_TDDL                   \ [0x10] Turn disable data lanes This bit forces the data lane to remain in RX event if it receives a bus-turn-around request from the other side.
    $12 constant DSIHOST_PDEN                   \ [0x12] Pull-down enable This bit enables a pull-down on the lane to prevent from floating states when unused.
    $13 constant DSIHOST_TCLKPREPEN             \ [0x13] Custom time for t<sub>CLK-PREPARE</sub> enable This bit enables the manual programming of t<sub>CLK-PREPARE </sub>duration in the D-PHY. The desired value must be programmed in the TLKCPREP field of the DSI_WPCR2 register.
    $14 constant DSIHOST_TCLKZEROEN             \ [0x14] Custom time for t<sub>CLK-ZERO</sub> enable This bit enables the manual programming of t<sub>CLK-ZERO </sub>duration in the D-PHY. The desired value must be programmed in the TCLKZERO field of the DSI_WPCR2 register.
    $15 constant DSIHOST_THSPREPEN              \ [0x15] Custom time for t<sub>HS-PREPARE</sub> enable This bit enables the manual programming of t<sub>HS-PREPARE </sub>duration in the D-PHY. The desired value must be programmed in the THSPREP field of the DSI_WPCR2 register.
    $16 constant DSIHOST_THSTRAILEN             \ [0x16] Custom time for t<sub>HS-TRAIL</sub> enable This bit enables the manual programming of T<sub>HS-TRAIL </sub>duration in the D-PHY. The desired value must be programmed in the THSRAIL field of the DSI_WPCR2 register.
    $17 constant DSIHOST_THSZEROEN              \ [0x17] Custom time for t<sub>HS-ZERO</sub> enable This bit enables the manual programming of t<sub>HS-ZERO </sub>duration in the D-PHY. The desired value must be programmed in the THSZERO field of the DSI_WPCR3 register.
    $18 constant DSIHOST_TLPXDEN                \ [0x18] Custom time for t<sub>LPX</sub> for data lanes enable This bit enables the manual programming of T<sub>LPX </sub>duration for the data lanes in the D-PHY. The desired value must be programmed in the TLPXD field of the DSI_WPCR3 register.
    $19 constant DSIHOST_THSEXITEN              \ [0x19] Custom time for t<sub>HS-EXIT</sub> enable This bit enables the manual programming of t<sub>HS-EXIT </sub>duration in the D-PHY. The desired value must be programmed in the THSEXIT field of the DSI_WPCR3 register.
    $1a constant DSIHOST_TLPXCEN                \ [0x1a] Custom time for t<sub>LPX</sub> for clock lane enable This bit enables the manual programming of t<sub>LPX</sub> duration for the clock lane in the D-PHY. The desired value must be programmed in the TLPXC field of the DSI_WPCR3 register.
    $1b constant DSIHOST_TCLKPOSTEN             \ [0x1b] Custom time for t<sub>CLK-POST</sub> enable This bit enables the manual programming of t<sub>CLK-POST </sub>duration in the D-PHY. The desired value must be programmed in the TCLKPOST field of the DSI_WPCR4 register.
  [then]


  [ifdef] DSIHOST_DSI_WPCR1_DEF
    \
    \ @brief DSI Wrapper PHY configuration register 1
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HSTXDCL                \ [0x00 : 2] High-speed transmission delay on clock lane Delay tuner control to change delay (up to DP/DN) in clock path. Can be used to change clock edge position with respect to data bit transitions on DP/DN. Default value = 00.
    $02 constant DSIHOST_HSTXDDL                \ [0x02 : 2] High-speed transmission delay on data lanes Delay tuner control to change delay (up to DP/DN) in data path. Can be used to change data edge transition positions with respect to clock edge on DP/DN. Default value = 00.
    $06 constant DSIHOST_LPSRCCL                \ [0x06 : 2] Low-power transmission slew-rate compensation on clock lane Can be used to change slew-rate of clock lane LP transitions. Default value = 00.
    $08 constant DSIHOST_LPSRCDL                \ [0x08 : 2] Low-power transmission slew-rate compensation on data lanes Can be used to change slew-rate of data lane LP transitions. Default value = 00.
    $0c constant DSIHOST_SDDC                   \ [0x0c] SDD control This bit switches on the additional current path to meet the SDDTx parameter defined by MIPI<sup></sup> D-PHY Specification on both clock and data lanes.
    $10 constant DSIHOST_HSTXSRCCL              \ [0x10 : 2] High-speed transmission slew-rate control on clock lane Slew-rate control for high-speed transmitter output. It can be used to change slew-rate of clock lane HS transitions. Default value = 00.
    $12 constant DSIHOST_HSTXSRCDL              \ [0x12 : 2] High-speed transmission slew-rate control on data lanes Slew-rate control for high-speed transmitter output. It can be used to change slew-rate of data lane HS transitions. Default value = 00.
    $16 constant DSIHOST_FLPRXLPM               \ [0x16] Forces LP receiver in low-power mode This bit enables the low-power mode of LP receiver (LPRX). When set, the LPRX operates in low-power mode all the time (when this is not activated, LPRX operates in low power mode during ULPS only).
    $19 constant DSIHOST_LPRXFT                 \ [0x19 : 2] Low-power RX low-pass filtering tuning This signal can be used to tune the cutoff frequency of low-pass filter at the input of LPRX.
  [then]


  [ifdef] DSIHOST_DSI_WPCR2_DEF
    \
    \ @brief DSI Wrapper PHY configuration register 2
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TCLKPREP               \ [0x00 : 8] t<sub>CLK-PREPARE</sub> This field defines the t<sub>CLK-PREPARE</sub> has specified in the MIPI<sup></sup> D-PHY specification. This value is used by the D-PHY when the TCLKPREPEN bit of the DSI_WPCR0 is set. TCLKPREP = 2 x t<sub>CLK-PREPARE</sub> expressed in ns.The default value used by the D-PHY when TCLKPREPEN bit of the DSI_WPCR0 is reset is 120 (60ns + 20*UI).
    $08 constant DSIHOST_TCLKZERO               \ [0x08 : 8] t<sub>CLK-ZERO</sub> This field defines the t<sub>CLK-ZERO</sub> has specified in the MIPI<sup></sup> D-PHY specification. This value is used by the D-PHY when the TCLKZEROEN bit of the DSI_WPCR0 is set. TCLKZERO = t<sub>CLK-ZERO</sub> / 2 expressed in ns.The default value used by the D-PHY when TCLKZEROEN bit of the DSI_WPCR0 is reset is 195 (390ns).
    $10 constant DSIHOST_THSPREP                \ [0x10 : 8] t<sub>HS-PREPARE</sub> This field defines the t<sub>HS-PREPARE</sub> has specified in the MIPI<sup></sup> D-PHY specification. This value is used by the D-PHY when the THSPREPEN bit of the DSI_WPCR0 is set. THSPREP = 2 x t<sub>HS-PREPARE</sub> expressed in ns.The default value used by the D-PHY when THSPREPEN bit of the DSI_WPCR0 is reset is 126 (63ns + 12*UI).
    $18 constant DSIHOST_THSTRAIL               \ [0x18 : 8] t<sub>HSTRAIL</sub> This field defines the t<sub>HS-TRAIL</sub> has specified in the MIPI<sup></sup> D-PHY specification. This value is used by the D-PHY when the THSTRAILEN bit of the DSI_WPCR0 is set. THSTRAIL = 2 x t<sub>HS-TRAIL</sub> expressed in ns.The default value used by the D-PHY when THSTRAILEN bit of the DSI_WPCR0 is reset is 140 (70ns+8*UI).
  [then]


  [ifdef] DSIHOST_DSI_WPCR3_DEF
    \
    \ @brief DSI Wrapper PHY configuration register 3
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_THSZERO                \ [0x00 : 8] t<sub>HS-ZERO</sub> This field defines the t<sub>HS-ZERO</sub> has specified in the MIPI<sup></sup> D-PHY specification. This value is used by the D-PHY when the THSZEROEN bit of the DSI_WPCR1 is set. THSZERO = t<sub>HS-ZERO</sub> expressed in ns.The default value used by the D-PHY when THSZEROEN bit of the DSI_WPCR1 is reset is 175, (175ns).
    $08 constant DSIHOST_TLPXD                  \ [0x08 : 8] t<sub>LPX</sub> for data lanes This field defines the t<sub>LPX</sub> has specified in the MIPI<sup></sup> D-PHY specification for the data lanes. This value is used by the D-PHY when the TLPXDEN bit of the DSI_WPCR1 is set. TLPXD = 2 x t<sub>LPX</sub> expressed in ns.The default value used by the D-PHY when TLPXDEN bit of the DSI_WPCR1 is reset is 100 (50ns).
    $10 constant DSIHOST_THSEXIT                \ [0x10 : 8] t<sub>HSEXIT</sub> This field defines the t<sub>HS-EXHigh-SpeedIT</sub> has specified in the MIPI<sup></sup> D-PHY specification. This value is used by the D-PHY when the THSEXITEN bit of the DSI_WPCR1 is set. THSEXIT = t<sub>HS-ZERO</sub> expressed in ns.The default value used by the D-PHY when THSEXITEN bit of the DSI_WPCR1 is reset is 100 (100ns).
    $18 constant DSIHOST_TLPXC                  \ [0x18 : 8] t<sub>LPXC</sub> for clock lane This field defines the t<sub>LPX</sub> has specified in the MIPI<sup></sup> D-PHY specification for the clock lane. This value is used by the D-PHY when the TLPXCEN bit of the DSI_WPCR1 is set. TLPXC = 2 x t<sub>LPX</sub> expressed in ns.The default value used by the D-PHY when TLPXCEN bit of the DSI_WPCR1 is reset is 100 (50ns).
  [then]


  [ifdef] DSIHOST_DSI_WPCR4_DEF
    \
    \ @brief DSI Wrapper PHY configuration register 4
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TCLKPOST               \ [0x00 : 8] t<sub>CLK-POST</sub> This field defines the t<sub>CLK-POST</sub> has specified in the MIPI<sup></sup> D-PHY specification. This value is used by the D-PHY when the TCLKPOSTEN bit of the DSI_WPCR0 is set. TCLKPOST = 2 x t<sub>CLK-POST</sub> expressed in ns.The default value used by the D-PHY when TCLKPOSTEN bit of the DSI_WPCR0 is reset is 200 (100ns + 120*UI).
  [then]


  [ifdef] DSIHOST_DSI_WRPCR_DEF
    \
    \ @brief DSI Wrapper regulator and PLL control register
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_PLLEN                  \ [0x00] PLL enable This bit enables the D-PHY PLL.
    $02 constant DSIHOST_NDIV                   \ [0x02 : 7] PLL loop division factor This field configures the PLL loop division factor. 10 to 125: Allowed loop division factor values Others: Reserved
    $0b constant DSIHOST_IDF                    \ [0x0b : 4] PLL input division factor This field configures the PLL input division factor.
    $10 constant DSIHOST_ODF                    \ [0x10 : 2] PLL output division factor This field configures the PLL output division factor.
    $18 constant DSIHOST_REGEN                  \ [0x18] Regulator enable This bit enables the DPHY regulator.
  [then]

  \
  \ @brief DSI Host
  \
  $00 constant DSIHOST_DSI_VR           \ DSI Host version register
  $04 constant DSIHOST_DSI_CR           \ DSI Host control register
  $08 constant DSIHOST_DSI_CCR          \ DSI Host clock control register
  $0C constant DSIHOST_DSI_LVCIDR       \ DSI Host LTDC VCID register
  $10 constant DSIHOST_DSI_LCOLCR       \ DSI Host LTDC color coding register
  $14 constant DSIHOST_DSI_LPCR         \ DSI Host LTDC polarity configuration register
  $18 constant DSIHOST_DSI_LPMCR        \ DSI Host low-power mode configuration register
  $2C constant DSIHOST_DSI_PCR          \ DSI Host protocol configuration register
  $30 constant DSIHOST_DSI_GVCIDR       \ DSI Host generic VCID register
  $34 constant DSIHOST_DSI_MCR          \ DSI Host mode configuration register
  $38 constant DSIHOST_DSI_VMCR         \ DSI Host video mode configuration register
  $3C constant DSIHOST_DSI_VPCR         \ DSI Host video packet configuration register
  $40 constant DSIHOST_DSI_VCCR         \ DSI Host video chunks configuration register
  $44 constant DSIHOST_DSI_VNPCR        \ DSI Host video null packet configuration register
  $48 constant DSIHOST_DSI_VHSACR       \ DSI Host video HSA configuration register
  $4C constant DSIHOST_DSI_VHBPCR       \ DSI Host video HBP configuration register
  $50 constant DSIHOST_DSI_VLCR         \ DSI Host video line configuration register
  $54 constant DSIHOST_DSI_VVSACR       \ DSI Host video VSA configuration register
  $58 constant DSIHOST_DSI_VVBPCR       \ DSI Host video VBP configuration register
  $5C constant DSIHOST_DSI_VVFPCR       \ DSI Host video VFP configuration register
  $60 constant DSIHOST_DSI_VVACR        \ DSI Host video VA configuration register
  $64 constant DSIHOST_DSI_LCCR         \ DSI Host LTDC command configuration register
  $68 constant DSIHOST_DSI_CMCR         \ DSI Host command mode configuration register
  $6C constant DSIHOST_DSI_GHCR         \ DSI Host generic header configuration register
  $70 constant DSIHOST_DSI_GPDR         \ DSI Host generic payload data register
  $74 constant DSIHOST_DSI_GPSR         \ DSI Host generic packet status register
  $78 constant DSIHOST_DSI_TCCR0        \ DSI Host timeout counter configuration register 0
  $7C constant DSIHOST_DSI_TCCR1        \ DSI Host timeout counter configuration register 1
  $80 constant DSIHOST_DSI_TCCR2        \ DSI Host timeout counter configuration register 2
  $84 constant DSIHOST_DSI_TCCR3        \ DSI Host timeout counter configuration register 3
  $88 constant DSIHOST_DSI_TCCR4        \ DSI Host timeout counter configuration register 4
  $8C constant DSIHOST_DSI_TCCR5        \ DSI Host timeout counter configuration register 5
  $94 constant DSIHOST_DSI_CLCR         \ DSI Host clock lane configuration register
  $98 constant DSIHOST_DSI_CLTCR        \ DSI Host clock lane timer configuration register
  $9C constant DSIHOST_DSI_DLTCR        \ DSI Host data lane timer configuration register
  $A0 constant DSIHOST_DSI_PCTLR        \ DSI Host PHY control register
  $A4 constant DSIHOST_DSI_PCONFR       \ DSI Host PHY configuration register
  $A8 constant DSIHOST_DSI_PUCR         \ DSI Host PHY ULPS control register
  $AC constant DSIHOST_DSI_PTTCR        \ DSI Host PHY TX triggers configuration register
  $B0 constant DSIHOST_DSI_PSR          \ DSI Host PHY status register
  $BC constant DSIHOST_DSI_ISR0         \ DSI Host interrupt and status register 0
  $C0 constant DSIHOST_DSI_ISR1         \ DSI Host interrupt and status register 1
  $C4 constant DSIHOST_DSI_IER0         \ DSI Host interrupt enable register 0
  $C8 constant DSIHOST_DSI_IER1         \ DSI Host interrupt enable register 1
  $D8 constant DSIHOST_DSI_FIR0         \ DSI Host force interrupt register 0
  $DC constant DSIHOST_DSI_FIR1         \ DSI Host force interrupt register 1
  $100 constant DSIHOST_DSI_VSCR        \ DSI Host video shadow control register
  $10C constant DSIHOST_DSI_LCVCIDR     \ DSI Host LTDC current VCID register
  $110 constant DSIHOST_DSI_LCCCR       \ DSI Host LTDC current color coding register
  $118 constant DSIHOST_DSI_LPMCCR      \ DSI Host low-power mode current configuration register
  $138 constant DSIHOST_DSI_VMCCR       \ DSI Host video mode current configuration register
  $13C constant DSIHOST_DSI_VPCCR       \ DSI Host video packet current configuration register
  $140 constant DSIHOST_DSI_VCCCR       \ DSI Host video chunks current configuration register
  $144 constant DSIHOST_DSI_VNPCCR      \ DSI Host video null packet current configuration register
  $148 constant DSIHOST_DSI_VHSACCR     \ DSI Host video HSA current configuration register
  $14C constant DSIHOST_DSI_VHBPCCR     \ DSI Host video HBP current configuration register
  $150 constant DSIHOST_DSI_VLCCR       \ DSI Host video line current configuration register
  $154 constant DSIHOST_DSI_VVSACCR     \ DSI Host video VSA current configuration register
  $158 constant DSIHOST_DSI_VVBPCCR     \ DSI Host video VBP current configuration register
  $15C constant DSIHOST_DSI_VVFPCCR     \ DSI Host video VFP current configuration register
  $160 constant DSIHOST_DSI_VVACCR      \ DSI Host video VA current configuration register
  $400 constant DSIHOST_DSI_WCFGR       \ DSI Wrapper configuration register
  $404 constant DSIHOST_DSI_WCR         \ DSI Wrapper control register
  $408 constant DSIHOST_DSI_WIER        \ DSI Wrapper interrupt enable register
  $40C constant DSIHOST_DSI_WISR        \ DSI Wrapper interrupt and status register
  $410 constant DSIHOST_DSI_WIFCR       \ DSI Wrapper interrupt flag clear register
  $418 constant DSIHOST_DSI_WPCR0       \ DSI Wrapper PHY configuration register 0
  $41C constant DSIHOST_DSI_WPCR1       \ DSI Wrapper PHY configuration register 1
  $420 constant DSIHOST_DSI_WPCR2       \ DSI Wrapper PHY configuration register 2
  $424 constant DSIHOST_DSI_WPCR3       \ DSI Wrapper PHY configuration register 3
  $428 constant DSIHOST_DSI_WPCR4       \ DSI Wrapper PHY configuration register 4
  $430 constant DSIHOST_DSI_WRPCR       \ DSI Wrapper regulator and PLL control register

: DSIHOST_DEF ; [then]
