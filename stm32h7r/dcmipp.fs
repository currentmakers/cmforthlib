\
\ @file dcmipp.fs
\ @brief Digital camera interface pixel pipeline
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DCMIPP_DEF

  [ifdef] DCMIPP_DCMIPP_IPGR1_DEF
    \
    \ @brief DCMIPP IP-Plug global register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000002
    \
    $00 constant DCMIPP_MEMORYPAGE              \ [0x00 : 3] Memory page size, as power of 2 of 64-byte units:
    $18 constant DCMIPP_QOS_MODE                \ [0x18] Quality of service Set of functions enabling to build and configure an architecture able to meet bandwidth and latency requirements.
  [then]


  [ifdef] DCMIPP_DCMIPP_IPGR2_DEF
    \
    \ @brief DCMIPP IP-Plug global register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_PSTART                  \ [0x00] Request to lock the IP-Plug, to allow reconfiguration. PSTART must be reset to 0 after configuration is completed, to restart the IP-Plug.
  [then]


  [ifdef] DCMIPP_DCMIPP_IPGR3_DEF
    \
    \ @brief DCMIPP IP-Plug global register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000001
    \
    $00 constant DCMIPP_IDLE                    \ [0x00] Status of IP-Plug IDLE is set some time after a request by setting PSTART at 1, and reset by resetting PSTART at 0.
  [then]


  [ifdef] DCMIPP_DCMIPP_IPGR8_DEF
    \
    \ @brief DCMIPP IP-Plug identification register
    \ Address offset: 0x1C
    \ Reset value: 0xAA040314
    \
    $00 constant DCMIPP_DID                     \ [0x00 : 6] Division identifier (0x14)
    $08 constant DCMIPP_REVID                   \ [0x08 : 5] Revision identifier (0x03)
    $10 constant DCMIPP_ARCHIID                 \ [0x10 : 5] Architecture identifier (0x04)
    $18 constant DCMIPP_IPPID                   \ [0x18 : 8] IP identifier (0xAA)
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC1R1_DEF
    \
    \ @brief DCMIPP IP-Plug Clientx register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000003
    \
    $00 constant DCMIPP_TRAFFIC                 \ [0x00 : 3] Burst size as power of 2 of 8-byte units Other values: Reserved
    $08 constant DCMIPP_OTR                     \ [0x08 : 2] Maximum outstanding transactions ... Other values are not allowed.
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC1R2_DEF
    \
    \ @brief DCMIPP IP-Plug Clientx register 2
    \ Address offset: 0x24
    \ Reset value: 0x00010000
    \
    $08 constant DCMIPP_SVCMAPPING              \ [0x08 : 4] Non-user, must be kept at reset value.
    $10 constant DCMIPP_WLRU                    \ [0x10 : 4] Ratio for WLRU[3:0] arbitration A client gets a portion of the total bandwidth = Ratio(client) / Sum(all ratio) ...
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC1R3_DEF
    \
    \ @brief DCMIPP IP-Plug Clientx register 3
    \ Address offset: 0x28
    \ Reset value: 0x001F0000
    \
    $00 constant DCMIPP_DPREGSTART              \ [0x00 : 5] Start word (AXI width = 64 bits) of the FIFO of Clientx.
    $10 constant DCMIPP_DPREGEND                \ [0x10 : 5] End word (AXI width = 64 bits) of the FIFO of Clientx. The addressed word is included in the FIFO, so that next DPREGSTART is DPREGEND + 1.
  [then]


  [ifdef] DCMIPP_DCMIPP_PRCR_DEF
    \
    \ @brief DCMIPP parallel interface control register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $04 constant DCMIPP_ESS                     \ [0x04] Embedded synchronization select Valid only for 8-bit parallel data. HSPOL/VSPOL are ignored when this bit is set.
    $05 constant DCMIPP_PCKPOL                  \ [0x05] Pixel clock polarity This bit configures the capture edge of the pixel clock
    $06 constant DCMIPP_HSPOL                   \ [0x06] Horizontal synchronization polarity This bit indicates the level on the HSYNC pin when the data are not valid on the parallel interface.
    $07 constant DCMIPP_VSPOL                   \ [0x07] Vertical synchronization polarity This bit indicates the level on the VSYNC pin when the data are not valid on the parallel interface.
    $0a constant DCMIPP_EDM                     \ [0x0a : 3] Extended data mode Other values: Reserved.
    $0e constant DCMIPP_ENABLE                  \ [0x0e] Parallel interface enable The parallel interface configuration registers must be correctly programmed before enabling this bit.
    $10 constant DCMIPP_FORMAT                  \ [0x10 : 8] Other values: data are captured and output as-is only through the data/dump pipeline (for example JPEG or byte input format). The monochrome Y input is inserted in the pipe as YUV pixels, with the U and V components set to neutral, to represent a grey color.
    $19 constant DCMIPP_SWAPCYCLES              \ [0x19] Swap data (cycle 0 vs. cycle 1) for pixels received on two cycles The swap must not be activated by software for pixels received in one or three cycles.
    $1a constant DCMIPP_SWAPBITS                \ [0x1a] Swap LSB vs. MSB within each received component
  [then]


  [ifdef] DCMIPP_DCMIPP_PRESCR_DEF
    \
    \ @brief DCMIPP parallel interface embedded synchronization code register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FSC                     \ [0x00 : 8] Frame start delimiter code This byte specifies the code of the frame start delimiter. The code consists of four bytes in the form of 0xFF, 0x00, 0x00, FSC. If FSC is programmed to 0xFF, no frame start delimiter is detected, but the first occurrence of LSC after an FEC code is interpreted as the start of frame delimiter.
    $08 constant DCMIPP_LSC                     \ [0x08 : 8] Line start delimiter code This byte specifies the code of the line start delimiter. The code consists of four bytes in the form of 0xFF, 0x00, 0x00, LSC.
    $10 constant DCMIPP_LEC                     \ [0x10 : 8] Line end delimiter code This byte specifies the code of the line end delimiter. The code consists of four bytes in the form of 0xFF, 0x00, 0x00, LEC.
    $18 constant DCMIPP_FEC                     \ [0x18 : 8] Frame end delimiter code This byte specifies the code of the frame end delimiter. The code consists of four bytes in the form of 0xFF, 0x00, 0x00, FEC. If FEC is programmed to 0xFF, all the unused codes (0xFF00 00XY) are interpreted as frame end delimiters.
  [then]


  [ifdef] DCMIPP_DCMIPP_PRESUR_DEF
    \
    \ @brief DCMIPP parallel interface embedded synchronization unmask register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FSU                     \ [0x00 : 8] Frame start delimiter unmask This byte specifies the mask to be applied to the code of the frame start delimiter.
    $08 constant DCMIPP_LSU                     \ [0x08 : 8] Line start delimiter unmask This byte specifies the mask to be applied to the code of the line start delimiter.
    $10 constant DCMIPP_LEU                     \ [0x10 : 8] Line end delimiter unmask This byte specifies the mask to be applied to the code of the line end delimiter.
    $18 constant DCMIPP_FEU                     \ [0x18 : 8] Frame end delimiter unmask This byte specifies the mask to be applied to the code of the frame end delimiter.
  [then]


  [ifdef] DCMIPP_DCMIPP_PRIER_DEF
    \
    \ @brief DCMIPP parallel interface interrupt enable register
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $06 constant DCMIPP_ERRIE                   \ [0x06] Synchronization error interrupt enable This bit is available only in embedded synchronization mode.
  [then]


  [ifdef] DCMIPP_DCMIPP_PRSR_DEF
    \
    \ @brief DCMIPP parallel interface status register
    \ Address offset: 0x1F8
    \ Reset value: 0x00030000
    \
    $06 constant DCMIPP_ERRF                    \ [0x06] Synchronization error raw interrupt status This bit is valid only in the embedded synchronization mode. It is cleared by writing a 1 to the CERRF bit in DCMIPP_PRFCR. This bit is available only in embedded synchronization mode.
    $10 constant DCMIPP_HSYNC                   \ [0x10] This bit gives the state of the HSYNC pin with the correct programmed polarity if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in HPOL bit, and cleared otherwise. When embedded synchronization codes are used: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in DCMIPP_CR is set.
    $11 constant DCMIPP_VSYNC                   \ [0x11] This bit gives the state of the VSYNC pin with the correct programmed polarity if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in VPOL bit, and cleared otherwise. When embedded synchronization codes are used: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in DCMIPP_CR is set.
  [then]


  [ifdef] DCMIPP_DCMIPP_PRFCR_DEF
    \
    \ @brief DCMIPP parallel interface interrupt clear register
    \ Address offset: 0x1FC
    \ Reset value: 0x00000000
    \
    $06 constant DCMIPP_CERRF                   \ [0x06] Synchronization error interrupt status clear Writing a 1 into this bit clears the ERRF bit in DCMIPP_PRSR. This bit is available only in embedded synchronization mode.
  [then]


  [ifdef] DCMIPP_DCMIPP_CMCR_DEF
    \
    \ @brief DCMIPP common configuration register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $04 constant DCMIPP_CFC                     \ [0x04] Clear frame counter When this bit is set, the frame counter associated to a pipe is cleared. It resets DCMIPP_CMFRCR register. This bit is always read at 0.
  [then]


  [ifdef] DCMIPP_DCMIPP_CMFRCR_DEF
    \
    \ @brief DCMIPP common frame counter register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FRMCNT                  \ [0x00 : 32] Frame counter, read-only, loops around. Incremented following VSYNC detection mapped to the pipe configured into bits PSFC[1:0] of the DCMIPP_CMCR register. The counter is cleared using the CRC bit in the DCMIPP_CMCR register.
  [then]


  [ifdef] DCMIPP_DCMIPP_CMIER_DEF
    \
    \ @brief DCMIPP common interrupt enable register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $05 constant DCMIPP_ATXERRIE                \ [0x05] AXI transfer error interrupt enable for IP-Plug
    $06 constant DCMIPP_PRERRIE                 \ [0x06] Limit interrupt enable for the parallel Interface
    $08 constant DCMIPP_P0LINEIE                \ [0x08] Multi-line capture complete interrupt enable for Pipe0
    $09 constant DCMIPP_P0FRAMEIE               \ [0x09] Frame capture complete interrupt enable for Pipe0
    $0a constant DCMIPP_P0VSYNCIE               \ [0x0a] Vertical sync interrupt enable for Pipe0
    $0e constant DCMIPP_P0LIMITIE               \ [0x0e] Limit interrupt enable for Pipe0
    $0f constant DCMIPP_P0OVRIE                 \ [0x0f] Overrun interrupt enable for Pipe0
  [then]


  [ifdef] DCMIPP_DCMIPP_CMSR1_DEF
    \
    \ @brief DCMIPP common status register 1
    \ Address offset: 0x3F4
    \ Reset value: 0x00000003
    \
    $00 constant DCMIPP_PRHSYNC                 \ [0x00] This bit gives the state of the HSYNC pin with the correct programmed polarity on the parallel interface if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in HPOL bit of the DCMIPP_PRCR register, and cleared otherwise. When embedded synchronization codes are used the meaning of this bit is the following: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in the DCMIPP_PRCR register is set.
    $01 constant DCMIPP_PRVSYNC                 \ [0x01] This bit gives the state of the VSYNC pin with the correct programmed polarity on the parallel interface if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in VPOL bit of the DCMIPP_PRCR register, and cleared otherwise. When embedded synchronization codes are used, the meaning of this bit is the following: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in the DCMIPP_PRCR register is set.
    $0f constant DCMIPP_P0CPTACT                \ [0x0f] Active frame capture (active from start-of-frame to frame complete) for Pipe0
  [then]


  [ifdef] DCMIPP_DCMIPP_CMSR2_DEF
    \
    \ @brief DCMIPP common status register 2
    \ Address offset: 0x3F8
    \ Reset value: 0x00000000
    \
    $05 constant DCMIPP_ATXERRF                 \ [0x05] AXI transfer error interrupt status flag for the IP-Plug. This bit is cleared by writing a 1 to CATXERRF bit in the DCMIPP_CMFCR register.
    $06 constant DCMIPP_PRERRF                  \ [0x06] Synchronization error raw interrupt status for the parallel interface. This bit is valid only in the embedded synchronization mode. It is cleared by writing a 1 to the CPRERRF bit in the DCMIPP_CMFCR register. This bit is available only in embedded synchronization mode.
    $08 constant DCMIPP_P0LINEF                 \ [0x08] Multi-line capture completed raw interrupt status for Pipe0 This bit is set when one/more lines have been completed. The periodicity of LINEF event is configured by LINEMULT bits into DCMIPP_P0PPCR register. When reaching end of frame, this event is triggered out to allow software action even if the LINEMULT value set is not a multiple of the total lines frame. In the case of embedded synchronization, this bit is set only if the CAPTURE bit in the DCMIPP_CR register is set. It is cleared by writing a 1 to the CP0LINEF bit in the DCMIPP_CMFCR register.
    $09 constant DCMIPP_P0FRAMEF                \ [0x09] Frame capture completed raw interrupt status for Pipe0 This bit is set when all data of a frame or window have been captured. In case of a cropped window, this bit is set at the end of line of the last line in the crop, even if the captured frame is empty (for example window cropped outside the frame). This bit is cleared by writing a 1 to the CP0FRAMEF bit in the DCMIPP_CMFCR register.
    $0a constant DCMIPP_P0VSYNCF                \ [0x0a] VSYNC raw interrupt status for Pipe0 This bit is set when the VSYNC signal changes from the inactive state to the active state. In the case of embedded synchronization, this bit is set only if the CAPTURE bit is set in DCMIPP_CR. It is cleared by writing a 1 to the CP0VSYNCF bit in the DCMIPP_CMFCR register.
    $0e constant DCMIPP_P0LIMITF                \ [0x0e] Limit raw interrupt status for Pipe0 This bit is set when the data counter DCMIPP_P0DCCNT reaches its maximum value DCMIPP_P0DCLIMIT. It is cleared by writing a 1 to the CP0LIMITF bit in the DCMIPP_CMFCR register.
    $0f constant DCMIPP_P0OVRF                  \ [0x0f] Overrun raw interrupt status for Pipe0 This bit is cleared by writing a 1 to the CP0OVRF bit in the DCMIPP_CMFCR register.
  [then]


  [ifdef] DCMIPP_DCMIPP_CMFCR_DEF
    \
    \ @brief DCMIPP common interrupt clear register
    \ Address offset: 0x3FC
    \ Reset value: 0x00000000
    \
    $05 constant DCMIPP_CATXERRF                \ [0x05] AXI transfer error interrupt status clear Writing a 1 into this bit clears the ATXERRF bit in the DCMIPP_CMSR2 register.
    $06 constant DCMIPP_CPRERRF                 \ [0x06] Synchronization error interrupt status clear Writing a 1 into this bit clears the PRERRF bit in the DCMIPP_CMSR2 register. This bit is available only in embedded synchronization mode.
    $08 constant DCMIPP_CP0LINEF                \ [0x08] Multi-line capture complete interrupt status clear Writing a 1 into this bit clears P0LINEF in the DCMIPP_CMSR2 register
    $09 constant DCMIPP_CP0FRAMEF               \ [0x09] Frame capture complete interrupt status clear Writing a 1 into this bit clears the P0FRAMEF bit in the DCMIPP_CMSR2 register.
    $0a constant DCMIPP_CP0VSYNCF               \ [0x0a] Vertical synchronization interrupt status clear Writing a 1 into this bit clears the P0VSYNCF bit in the DCMIPP_CMSR2 register.
    $0e constant DCMIPP_CP0LIMITF               \ [0x0e] limit interrupt status clear Writing a 1 into this bit clears P0LIMITF in the DCMIPP_CMSR2 register
    $0f constant DCMIPP_CP0OVRF                 \ [0x0f] Overrun interrupt status clear Writing a 1 into this bit clears the P0OVRF bit in the DCMIPP_CMSR2 register
  [then]


  [ifdef] DCMIPP_DCMIPP_P0FSCR_DEF
    \
    \ @brief DCMIPP Pipe0 flow selection configuration register
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $1f constant DCMIPP_PIPEN                   \ [0x1f] Activation of PipeN Note: This bit is not shadowed, differently from all other bits in this register.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0FCTCR_DEF
    \
    \ @brief DCMIPP Pipe0 flow control configuration register
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FRATE                   \ [0x00 : 2] Frame capture rate control These bits define the frequency of frame capture. They are meaningful only in Continuous grab mode, ignored in Snapshot mode.
    $02 constant DCMIPP_CPTMODE                 \ [0x02] Capture mode
    $03 constant DCMIPP_CPTREQ                  \ [0x03] Capture requested When PIPEN = 1 and when the CPTREQ is set to 1 the pipe waits for the first VSync, and automatically starts a capture and sets CPTACT = 1 to mention it. In Snapshot mode the CPTREQ bit is automatically cleared at the start of the first received frame. In Continuous grab mode, the capture remains active and CPTREQ = 1 until the software clears CPTREQ: the capture stops and CPTACT is reset at the end of the ongoing frame. The DCMI and pipe configuration registers must be correctly programmed before enabling this bit.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0SCSTR_DEF
    \
    \ @brief DCMIPP Pipe0 stat/crop start register
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 words wide
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P0SCSZR_DEF
    \
    \ @brief DCMIPP Pipe0 stat/crop size register
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 word wide (data 32-bit) If the value is maintained at 0 when enabling the crop by means of ENABLE bit, the crop operation is not performed on horizontal direction.
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high If the value is maintained at 0 when enabling the crop by means of ENABLE bit, the crop operation is not performed on vertical direction.
    $1e constant DCMIPP_POSNEG                  \ [0x1e] This bit is set and cleared by software. It has a meaning only if ENABLE bit is set.
    $1f constant DCMIPP_ENABLE                  \ [0x1f] This bit is set and cleared by software. if POSNEG = 0, the data inside the rectangle area are transmitted (it can correspond to a statistical data removal, or as a crop feature in a data valid image area). if POSNEG = 1, the data outside of the rectangle area are transmitted (it can correspond to a statistical data extraction, rejecting all data inside the window). This bit must be kept cleared if the input format is JPEG, to avoid unpredictable behavior of the pipe.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0DCCNTR_DEF
    \
    \ @brief DCMIPP Pipe0 dump counter register
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_CNT                     \ [0x00 : 26] Number of data dumped during the frame. The size of the data is expressed in bytes. It counts only the data selected by means of the CROP 2D function. The counter saturates at 0x3FFFFFF. Granularity is 32-bit for all the formats except for the byte stream formats (for example JPEG) having byte granularity.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0DCLMTR_DEF
    \
    \ @brief DCMIPP Pipe0 dump limit register
    \ Address offset: 0x5B4
    \ Reset value: 0x00FFFFFF
    \
    $00 constant DCMIPP_LIMIT                   \ [0x00 : 24] Maximum number of 32-bit data that can be dumped during a frame, after the crop 2D operation.
    $1f constant DCMIPP_ENABLE                  \ [0x1f] Disabled, no check on the amount of 32-bit words transmitted
  [then]


  [ifdef] DCMIPP_DCMIPP_P0PPCR_DEF
    \
    \ @brief DCMIPP Pipe0 pixel packer configuration register
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $05 constant DCMIPP_PAD                     \ [0x05] Pad mode for monochrome and raw Bayer 10/12/14 bpp: MSB vs. LSB alignment.
    $07 constant DCMIPP_BSM                     \ [0x07 : 2] Byte select mode Modes 10 and 11 work only with EDM [2:0] = 000 into the DCMIPP_PRCR register.
    $09 constant DCMIPP_OEBS                    \ [0x09] Odd/even byte select (byte select start) This bit works in conjunction with BSM field (BSM different from 00)
    $0a constant DCMIPP_LSM                     \ [0x0a] Line select mode
    $0b constant DCMIPP_OELS                    \ [0x0b] Odd/even line select (line select start) This bit works in conjunction with LSM field (LSM = 1).
    $0d constant DCMIPP_LINEMULT                \ [0x0d : 3] Amount of capture completed lines for LINE event and interrupt
    $10 constant DCMIPP_DBM                     \ [0x10] Double buffer mode This bit is set and cleared by software.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0PPM0AR1_DEF
    \
    \ @brief DCMIPP Pipe0 pixel packer Memory0 address register 1
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address Base address of memory area 0, to whom data are written. It is assumed to be a multiple of 16, hence its bits 3:0 are always at 0x0.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0PPM0AR2_DEF
    \
    \ @brief DCMIPP Pipe0 pixel packer Memory0 address register 2
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address Base address of memory area 0, to whom data are written. It is assumed to be a multiple of 16, hence its bits 3:0 are always at 0x0.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0IER_DEF
    \
    \ @brief DCMIPP Pipe0 interrupt enable register
    \ Address offset: 0x5F4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_LINEIE                  \ [0x00] Multi-line capture completed interrupt enable
    $01 constant DCMIPP_FRAMEIE                 \ [0x01] Frame capture completed interrupt enable
    $02 constant DCMIPP_VSYNCIE                 \ [0x02] VSYNC interrupt enable
    $06 constant DCMIPP_LIMITIE                 \ [0x06] Limit interrupt enable
    $07 constant DCMIPP_OVRIE                   \ [0x07] Overrun interrupt enable
  [then]


  [ifdef] DCMIPP_DCMIPP_P0SR_DEF
    \
    \ @brief DCMIPP Pipe0 status register
    \ Address offset: 0x5F8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_LINEF                   \ [0x00] Multi-line capture completed raw interrupt status This bit is set when one/more lines have been completed. For the JPEG mode, this bit is raised at the end of the frame. The periodicity of LINEF event is configured by LINEMULT bits into DCMIPP_P0PPCR register. When reaching end of frame, this event is triggered out to allow software action even if the LINEMULT value set is not a multiple of the total lines frame. In case of embedded synchronization, this bit is set only if the CAPTURE bit in the DCMIPP_CR register is set. It is cleared by writing a 1 to the CLINEF bit in the DCMIPP_P0FCR register.
    $01 constant DCMIPP_FRAMEF                  \ [0x01] Frame capture completed raw interrupt status This bit is set when all data of a frame or window have been captured. In case of a cropped window, this bit is set at the end of line of the last line in the crop. It is set even if the captured frame is empty (for example window cropped outside the frame). This bit is cleared by writing a 1 to the CFRAMEF bit in DCMIPP_P0FCR.
    $02 constant DCMIPP_VSYNCF                  \ [0x02] VSYNC raw interrupt status This bit is set when the VSYNC signal changes from the inactive state to the active state. In case of embedded synchronization, this bit is set only if the CAPTURE bit is set in DCMIPP_CR. It is cleared by writing a 1 to the CVSYNCF bit in the DCMIPP_P0FCR register.
    $06 constant DCMIPP_LIMITF                  \ [0x06] Limit raw interrupt status This bit is set when the data counter DCMIPP_PxDCCNTR reaches its maximum value DCMIPP_PxDCLIMITR. It is cleared by writing a 1 to the CLIMITF bit in the DCMIPP_P0FCR register.
    $07 constant DCMIPP_OVRF                    \ [0x07] Overrun raw interrupt status This bit is cleared by writing a 1 to the COVRF bit in the DCMIPP_P0FCR register.
    $17 constant DCMIPP_CPTACT                  \ [0x17] Capture immediate status This bit is automatically reset at the end of frame capture complete event (after all the data of that frame have been captured and the IP-Plug has started to emit the last burst on the AXI, usually before the next VSync).
  [then]


  [ifdef] DCMIPP_DCMIPP_P0FCR_DEF
    \
    \ @brief DCMIPP Pipe0 interrupt clear register
    \ Address offset: 0x5FC
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_CLINEF                  \ [0x00] Multi-line capture complete interrupt status clear Writing a 1 into this bit clears LINEF in the DCMIPP_P0SR register.
    $01 constant DCMIPP_CFRAMEF                 \ [0x01] Frame capture complete interrupt status clear Writing a 1 into this bit clears the FRAMEF bit in the DCMIPP_P0SR register.
    $02 constant DCMIPP_CVSYNCF                 \ [0x02] Vertical synchronization interrupt status clear Writing a 1 into this bit clears the VSYNCF bit in the DCMIPP_P0SR register.
    $06 constant DCMIPP_CLIMITF                 \ [0x06] limit interrupt status clear Writing a 1 into this bit clears LIMITF in the DCMIPP_P0SR register.
    $07 constant DCMIPP_COVRF                   \ [0x07] Overrun interrupt status clear Writing a 1 into this bit clears the OVRF bit in the DCMIPP_P0SR register.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0CFCTCR_DEF
    \
    \ @brief DCMIPP Pipe0 current flow control configuration register
    \ Address offset: 0x700
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FRATE                   \ [0x00 : 2] Frame capture rate control These bits define the frequency of frame capture. They are meaningful only in Continuous grab mode, ignored in Snapshot mode.
    $02 constant DCMIPP_CPTMODE                 \ [0x02] Capture mode
    $03 constant DCMIPP_CPTREQ                  \ [0x03] Capture requested When PIPEN = 1, and when the CPTREQ is set to 1 the pipe waits for the first VSync, and automatically starts a capture and sets CPTACT = 1 to mention it. In Snapshot mode the CPTREQ bit is automatically cleared at the start of the first frame received. In continuous grab mode the capture remains active and CPTREQ = 1, until the software clears CPTREQ: the capture stops and CPTACT is reset at the end of the ongoing frame. The DCMI and pipe configuration registers must be correctly programmed before enabling this bit.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0CSCSTR_DEF
    \
    \ @brief DCMIPP Pipe0 current stat/crop start register
    \ Address offset: 0x704
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 words wide
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P0CSCSZR_DEF
    \
    \ @brief DCMIPP Pipe0 current stat/crop size register
    \ Address offset: 0x708
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 word wide (data 32-bit). If the value is maintained at 0 when enabling the crop by means of the ENABLE bit, the value is forced internally at 0xFFE, which is the maximum value.
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high. If the value is maintained at 0 when enabling the crop by means of the ENABLE bit, the value is forced internally at 0xFFE which is the maximum value.
    $1e constant DCMIPP_POSNEG                  \ [0x1e] Current value of the POSNEG bit This bit has a meaning only if ENABLE bit is set.
    $1f constant DCMIPP_ENABLE                  \ [0x1f] Current value of the ENABLE bit if POSNEG = 0, the data inside the rectangle area are transmitted (can correspond to a statistical data removal, or as a crop feature in a data valid image area). if POSNEG = 1, the data outside of the rectangle area are transmitted (can correspond to a statistical data extraction, rejecting all data inside the window)
  [then]


  [ifdef] DCMIPP_DCMIPP_P0CPPCR_DEF
    \
    \ @brief DCMIPP Pipe0 current pixel packer configuration register
    \ Address offset: 0x7C0
    \ Reset value: 0x00000000
    \
    $05 constant DCMIPP_PAD                     \ [0x05] Current Pad mode for monochrome and raw Bayer 10/12/14 bpp: MSB vs. LSB alignment
    $07 constant DCMIPP_BSM                     \ [0x07 : 2] Current Byte select mode Modes 10 and 11 work only with EDM [2:0] = 000 into the DCMIPP_PRCR register.
    $09 constant DCMIPP_OEBS                    \ [0x09] Current odd/even byte select (byte select start) This bit works in conjunction with BSM field (BSM different from 00)
    $0a constant DCMIPP_LSM                     \ [0x0a] Current Line select mode
    $0b constant DCMIPP_OELS                    \ [0x0b] Current odd/even line select (ine select start) This bit works in conjunction with LSM field (LSM = 1)
    $0d constant DCMIPP_LINEMULT                \ [0x0d : 3] Current amount of capture completed lines for LINE event and interrupt
    $10 constant DCMIPP_DBM                     \ [0x10] Double buffer mode
  [then]


  [ifdef] DCMIPP_DCMIPP_P0CPPM0AR1_DEF
    \
    \ @brief DCMIPP Pipe0 current pixel packer Memory0 address register 1
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address Base address of the current memory area 0, to whom data are written. It is assumed to be a multiple of 16, hence its bits 3:0 are always at 0x0.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0CPPM0AR2_DEF
    \
    \ @brief DCMIPP Pipe0 current pixel packer Memory0 address register 2
    \ Address offset: 0x7C8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address Base address of the current memory area 0, to whom data are written. It is assumed to be a multiple of 16, hence its bits 3:0 are always at 0x0.
  [then]

  \
  \ @brief Digital camera interface pixel pipeline
  \
  $00 constant DCMIPP_DCMIPP_IPGR1      \ DCMIPP IP-Plug global register 1
  $04 constant DCMIPP_DCMIPP_IPGR2      \ DCMIPP IP-Plug global register 2
  $08 constant DCMIPP_DCMIPP_IPGR3      \ DCMIPP IP-Plug global register 3
  $1C constant DCMIPP_DCMIPP_IPGR8      \ DCMIPP IP-Plug identification register
  $20 constant DCMIPP_DCMIPP_IPC1R1     \ DCMIPP IP-Plug Clientx register 1
  $24 constant DCMIPP_DCMIPP_IPC1R2     \ DCMIPP IP-Plug Clientx register 2
  $28 constant DCMIPP_DCMIPP_IPC1R3     \ DCMIPP IP-Plug Clientx register 3
  $104 constant DCMIPP_DCMIPP_PRCR      \ DCMIPP parallel interface control register
  $108 constant DCMIPP_DCMIPP_PRESCR    \ DCMIPP parallel interface embedded synchronization code register
  $10C constant DCMIPP_DCMIPP_PRESUR    \ DCMIPP parallel interface embedded synchronization unmask register
  $1F4 constant DCMIPP_DCMIPP_PRIER     \ DCMIPP parallel interface interrupt enable register
  $1F8 constant DCMIPP_DCMIPP_PRSR      \ DCMIPP parallel interface status register
  $1FC constant DCMIPP_DCMIPP_PRFCR     \ DCMIPP parallel interface interrupt clear register
  $204 constant DCMIPP_DCMIPP_CMCR      \ DCMIPP common configuration register
  $208 constant DCMIPP_DCMIPP_CMFRCR    \ DCMIPP common frame counter register
  $3F0 constant DCMIPP_DCMIPP_CMIER     \ DCMIPP common interrupt enable register
  $3F4 constant DCMIPP_DCMIPP_CMSR1     \ DCMIPP common status register 1
  $3F8 constant DCMIPP_DCMIPP_CMSR2     \ DCMIPP common status register 2
  $3FC constant DCMIPP_DCMIPP_CMFCR     \ DCMIPP common interrupt clear register
  $404 constant DCMIPP_DCMIPP_P0FSCR    \ DCMIPP Pipe0 flow selection configuration register
  $500 constant DCMIPP_DCMIPP_P0FCTCR   \ DCMIPP Pipe0 flow control configuration register
  $504 constant DCMIPP_DCMIPP_P0SCSTR   \ DCMIPP Pipe0 stat/crop start register
  $508 constant DCMIPP_DCMIPP_P0SCSZR   \ DCMIPP Pipe0 stat/crop size register
  $5B0 constant DCMIPP_DCMIPP_P0DCCNTR  \ DCMIPP Pipe0 dump counter register
  $5B4 constant DCMIPP_DCMIPP_P0DCLMTR  \ DCMIPP Pipe0 dump limit register
  $5C0 constant DCMIPP_DCMIPP_P0PPCR    \ DCMIPP Pipe0 pixel packer configuration register
  $5C4 constant DCMIPP_DCMIPP_P0PPM0AR1 \ DCMIPP Pipe0 pixel packer Memory0 address register 1
  $5C8 constant DCMIPP_DCMIPP_P0PPM0AR2 \ DCMIPP Pipe0 pixel packer Memory0 address register 2
  $5F4 constant DCMIPP_DCMIPP_P0IER     \ DCMIPP Pipe0 interrupt enable register
  $5F8 constant DCMIPP_DCMIPP_P0SR      \ DCMIPP Pipe0 status register
  $5FC constant DCMIPP_DCMIPP_P0FCR     \ DCMIPP Pipe0 interrupt clear register
  $700 constant DCMIPP_DCMIPP_P0CFCTCR  \ DCMIPP Pipe0 current flow control configuration register
  $704 constant DCMIPP_DCMIPP_P0CSCSTR  \ DCMIPP Pipe0 current stat/crop start register
  $708 constant DCMIPP_DCMIPP_P0CSCSZR  \ DCMIPP Pipe0 current stat/crop size register
  $7C0 constant DCMIPP_DCMIPP_P0CPPCR   \ DCMIPP Pipe0 current pixel packer configuration register
  $7C4 constant DCMIPP_DCMIPP_P0CPPM0AR1    \ DCMIPP Pipe0 current pixel packer Memory0 address register 1
  $7C8 constant DCMIPP_DCMIPP_P0CPPM0AR2    \ DCMIPP Pipe0 current pixel packer Memory0 address register 2

: DCMIPP_DEF ; [then]
