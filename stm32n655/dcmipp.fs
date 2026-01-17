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
    \ @brief DCMIPP IPPLUG global register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000002
    \
    $00 constant DCMIPP_MEMORYPAGE              \ [0x00 : 3] Memory page size, as power of 2 of 64-byte units:
    $18 constant DCMIPP_QOS_MODE                \ [0x18] Quality of service
  [then]


  [ifdef] DCMIPP_DCMIPP_IPGR2_DEF
    \
    \ @brief DCMIPP IPPLUG global register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_PSTART                  \ [0x00] Request to lock the IP-Plug, to allow reconfiguration.
  [then]


  [ifdef] DCMIPP_DCMIPP_IPGR3_DEF
    \
    \ @brief DCMIPP IPPLUG global register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000001
    \
    $00 constant DCMIPP_IDLE                    \ [0x00] Status of IP-Plug
  [then]


  [ifdef] DCMIPP_DCMIPP_IPGR8_DEF
    \
    \ @brief DCMIPP IPPLUG identification register
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
    \ @brief DCMIPP IPPLUG Clientx register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000004
    \
    $00 constant DCMIPP_TRAFFIC                 \ [0x00 : 3] Burst size as power of 2 of 8-byte units
    $08 constant DCMIPP_OTR                     \ [0x08 : 4] Maximum outstanding transactions
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC1R2_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 2
    \ Address offset: 0x24
    \ Reset value: 0x00010000
    \
    $08 constant DCMIPP_SVCMAPPING              \ [0x08 : 4] Non-user, must be kept at reset value.
    $10 constant DCMIPP_WLRU                    \ [0x10 : 4] Ratio for WLRU[3:0] arbitration
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC1R3_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 3
    \ Address offset: 0x28
    \ Reset value: 0x007F0000
    \
    $00 constant DCMIPP_DPREGSTART              \ [0x00 : 10] Start word (AXI width = 64 bits) of the FIFO of Clientx.
    $10 constant DCMIPP_DPREGEND                \ [0x10 : 10] End word (AXI width = 64 bits) of the FIFO of Clientx.
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC2R1_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000004
    \
    $00 constant DCMIPP_TRAFFIC                 \ [0x00 : 3] Burst size as power of 2 of 8-byte units
    $08 constant DCMIPP_OTR                     \ [0x08 : 4] Maximum outstanding transactions
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC2R2_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 2
    \ Address offset: 0x34
    \ Reset value: 0x00010000
    \
    $08 constant DCMIPP_SVCMAPPING              \ [0x08 : 4] Non-user, must be kept at reset value.
    $10 constant DCMIPP_WLRU                    \ [0x10 : 4] Ratio for WLRU[3:0] arbitration
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC2R3_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 3
    \ Address offset: 0x38
    \ Reset value: 0x013F0080
    \
    $00 constant DCMIPP_DPREGSTART              \ [0x00 : 10] Start word (AXI width = 64 bits) of the FIFO of Clientx.
    $10 constant DCMIPP_DPREGEND                \ [0x10 : 10] End word (AXI width = 64 bits) of the FIFO of Clientx.
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC3R1_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 1
    \ Address offset: 0x40
    \ Reset value: 0x00000004
    \
    $00 constant DCMIPP_TRAFFIC                 \ [0x00 : 3] Burst size as power of 2 of 8-byte units
    $08 constant DCMIPP_OTR                     \ [0x08 : 4] Maximum outstanding transactions
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC3R2_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 2
    \ Address offset: 0x44
    \ Reset value: 0x00010000
    \
    $08 constant DCMIPP_SVCMAPPING              \ [0x08 : 4] Non-user, must be kept at reset value.
    $10 constant DCMIPP_WLRU                    \ [0x10 : 4] Ratio for WLRU[3:0] arbitration
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC3R3_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 3
    \ Address offset: 0x48
    \ Reset value: 0x018F0140
    \
    $00 constant DCMIPP_DPREGSTART              \ [0x00 : 10] Start word (AXI width = 64 bits) of the FIFO of Clientx.
    $10 constant DCMIPP_DPREGEND                \ [0x10 : 10] End word (AXI width = 64 bits) of the FIFO of Clientx.
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC4R1_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 1
    \ Address offset: 0x50
    \ Reset value: 0x00000004
    \
    $00 constant DCMIPP_TRAFFIC                 \ [0x00 : 3] Burst size as power of 2 of 8-byte units
    $08 constant DCMIPP_OTR                     \ [0x08 : 4] Maximum outstanding transactions
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC4R2_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 2
    \ Address offset: 0x54
    \ Reset value: 0x00010000
    \
    $08 constant DCMIPP_SVCMAPPING              \ [0x08 : 4] Non-user, must be kept at reset value.
    $10 constant DCMIPP_WLRU                    \ [0x10 : 4] Ratio for WLRU[3:0] arbitration
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC4R3_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 3
    \ Address offset: 0x58
    \ Reset value: 0x01BF0190
    \
    $00 constant DCMIPP_DPREGSTART              \ [0x00 : 10] Start word (AXI width = 64 bits) of the FIFO of Clientx.
    $10 constant DCMIPP_DPREGEND                \ [0x10 : 10] End word (AXI width = 64 bits) of the FIFO of Clientx.
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC5R1_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000004
    \
    $00 constant DCMIPP_TRAFFIC                 \ [0x00 : 3] Burst size as power of 2 of 8-byte units
    $08 constant DCMIPP_OTR                     \ [0x08 : 4] Maximum outstanding transactions
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC5R2_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 2
    \ Address offset: 0x64
    \ Reset value: 0x00010000
    \
    $08 constant DCMIPP_SVCMAPPING              \ [0x08 : 4] Non-user, must be kept at reset value.
    $10 constant DCMIPP_WLRU                    \ [0x10 : 4] Ratio for WLRU[3:0] arbitration
  [then]


  [ifdef] DCMIPP_DCMIPP_IPC5R3_DEF
    \
    \ @brief DCMIPP IPPLUG Clientx register 3
    \ Address offset: 0x68
    \ Reset value: 0x027F01C0
    \
    $00 constant DCMIPP_DPREGSTART              \ [0x00 : 10] Start word (AXI width = 64 bits) of the FIFO of Clientx.
    $10 constant DCMIPP_DPREGEND                \ [0x10 : 10] End word (AXI width = 64 bits) of the FIFO of Clientx.
  [then]


  [ifdef] DCMIPP_DCMIPP_PRCR_DEF
    \
    \ @brief DCMIPP parallel interface control register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $04 constant DCMIPP_ESS                     \ [0x04] Embedded synchronization select
    $05 constant DCMIPP_PCKPOL                  \ [0x05] Pixel clock polarity
    $06 constant DCMIPP_HSPOL                   \ [0x06] Horizontal synchronization polarity
    $07 constant DCMIPP_VSPOL                   \ [0x07] Vertical synchronization polarity
    $0a constant DCMIPP_EDM                     \ [0x0a : 3] Extended data mode
    $0e constant DCMIPP_ENABLE                  \ [0x0e] Parallel interface enable
    $10 constant DCMIPP_FORMAT                  \ [0x10 : 8] Other values: data are captured and output as-is only through the data/dump pipeline (e.g. JPEG or byte input format).
    $19 constant DCMIPP_SWAPCYCLES              \ [0x19] Swap data (cycle 0 vs. cycle 1) for pixels received on two cycles
    $1a constant DCMIPP_SWAPBITS                \ [0x1a] Swap LSB vs. MSB within each received component
  [then]


  [ifdef] DCMIPP_DCMIPP_PRESCR_DEF
    \
    \ @brief DCMIPP parallel interface embedded synchronization code register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FSC                     \ [0x00 : 8] Frame start delimiter code
    $08 constant DCMIPP_LSC                     \ [0x08 : 8] Line start delimiter code
    $10 constant DCMIPP_LEC                     \ [0x10 : 8] Line end delimiter code
    $18 constant DCMIPP_FEC                     \ [0x18 : 8] Frame end delimiter code
  [then]


  [ifdef] DCMIPP_DCMIPP_PRESUR_DEF
    \
    \ @brief DCMIPP parallel interface embedded synchronization unmask register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FSU                     \ [0x00 : 8] Frame start delimiter unmask
    $08 constant DCMIPP_LSU                     \ [0x08 : 8] Line start delimiter unmask
    $10 constant DCMIPP_LEU                     \ [0x10 : 8] Line end delimiter unmask
    $18 constant DCMIPP_FEU                     \ [0x18 : 8] Frame end delimiter unmask
  [then]


  [ifdef] DCMIPP_DCMIPP_PRIER_DEF
    \
    \ @brief DCMIPP parallel interface interrupt enable register
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $06 constant DCMIPP_ERRIE                   \ [0x06] Synchronization error interrupt enable
  [then]


  [ifdef] DCMIPP_DCMIPP_PRSR_DEF
    \
    \ @brief DCMIPP parallel interface status register
    \ Address offset: 0x1F8
    \ Reset value: 0x00030000
    \
    $06 constant DCMIPP_ERRF                    \ [0x06] Synchronization error raw interrupt status
    $10 constant DCMIPP_HSYNC                   \ [0x10] This bit gives the state of the HSYNC pin with the correct programmed polarity if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in HPOL bit, and cleared otherwise.
    $11 constant DCMIPP_VSYNC                   \ [0x11] This bit gives the state of the VSYNC pin with the correct programmed polarity if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in VPOL bit, and cleared otherwise.
  [then]


  [ifdef] DCMIPP_DCMIPP_PRFCR_DEF
    \
    \ @brief DCMIPP parallel interface interrupt clear register
    \ Address offset: 0x1FC
    \ Reset value: 0x00000000
    \
    $06 constant DCMIPP_CERRF                   \ [0x06] Synchronization error interrupt status clear
  [then]


  [ifdef] DCMIPP_DCMIPP_CMCR_DEF
    \
    \ @brief DCMIPP common configuration register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_INSEL                   \ [0x00] input selection
    $01 constant DCMIPP_PSFC                    \ [0x01 : 2] Pipe selection for the frame counter
    $04 constant DCMIPP_CFC                     \ [0x04] Clear frame counter
    $07 constant DCMIPP_SWAPRB                  \ [0x07] Swap R/U and B/V
  [then]


  [ifdef] DCMIPP_DCMIPP_CMFRCR_DEF
    \
    \ @brief DCMIPP common frame counter register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FRMCNT                  \ [0x00 : 32] Frame counter, read-only, loops around.
  [then]


  [ifdef] DCMIPP_DCMIPP_CMIER_DEF
    \
    \ @brief DCMIPP common interrupt enable register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $05 constant DCMIPP_ATXERRIE                \ [0x05] AXI transfer error interrupt enable for IPPLUG
    $06 constant DCMIPP_PRERRIE                 \ [0x06] Limit interrupt enable for the parallel Interface
    $08 constant DCMIPP_P0LINEIE                \ [0x08] Multi-line capture complete interrupt enable for Pipe0
    $09 constant DCMIPP_P0FRAMEIE               \ [0x09] Frame capture complete interrupt enable for Pipe0
    $0a constant DCMIPP_P0VSYNCIE               \ [0x0a] Vertical sync interrupt enable for Pipe0
    $0e constant DCMIPP_P0LIMITIE               \ [0x0e] Limit interrupt enable for Pipe0
    $0f constant DCMIPP_P0OVRIE                 \ [0x0f] Overrun interrupt enable for Pipe0
    $10 constant DCMIPP_P1LINEIE                \ [0x10] Multi-line capture complete interrupt status clear for Pipe1
    $11 constant DCMIPP_P1FRAMEIE               \ [0x11] Frame capture complete interrupt enable for Pipe1
    $12 constant DCMIPP_P1VSYNCIE               \ [0x12] Vertical sync interrupt enable for Pipe1
    $17 constant DCMIPP_P1OVRIE                 \ [0x17] Overrun interrupt enable for Pipe1
    $18 constant DCMIPP_P2LINEIE                \ [0x18] Multi-line capture complete interrupt enable for Pipe2
    $19 constant DCMIPP_P2FRAMEIE               \ [0x19] Frame capture complete interrupt enable for Pipe2
    $1a constant DCMIPP_P2VSYNCIE               \ [0x1a] Vertical sync interrupt enable for Pipe2
    $1f constant DCMIPP_P2OVRIE                 \ [0x1f] Overrun interrupt status enable for Pipe2
  [then]


  [ifdef] DCMIPP_DCMIPP_CMSR1_DEF
    \
    \ @brief DCMIPP common status register 1
    \ Address offset: 0x3F4
    \ Reset value: 0x00000003
    \
    $00 constant DCMIPP_PRHSYNC                 \ [0x00] This bit gives the state of the HSYNC pin with the correct programmed polarity on the parallel interface if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in HPOL bit of the DCMIPP_PRCR register, and cleared otherwise.
    $01 constant DCMIPP_PRVSYNC                 \ [0x01] This bit gives the state of the VSYNC pin with the correct programmed polarity on the parallel interface if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in VPOL bit of the DCMIPP_PRCR register, and cleared otherwise.
    $08 constant DCMIPP_P0LSTLINE               \ [0x08] Last line LSB bit, sampled at Frame capture complete event for Pipe0
    $09 constant DCMIPP_P0LSTFRM                \ [0x09] Last frame LSB bit, sampled at Frame capture complete event for Pipe0
    $0f constant DCMIPP_P0CPTACT                \ [0x0f] Active frame capture (active from start-of-frame to frame complete) for Pipe0
    $10 constant DCMIPP_P1LSTLINE               \ [0x10] Last line LSB bit, sampled at Frame capture complete event for Pipe1
    $11 constant DCMIPP_P1LSTFRM                \ [0x11] Last frame LSB bit, sampled at frame capture complete event for Pipe1
    $17 constant DCMIPP_P1CPTACT                \ [0x17] Active frame capture (active from start-of-frame to frame complete) for Pipe1
    $18 constant DCMIPP_P2LSTLINE               \ [0x18] Last line LSB bit, sampled at frame capture complete event for Pipe2
    $19 constant DCMIPP_P2LSTFRM                \ [0x19] Last frame LSB bit, sampled at frame capture complete event for Pipe2
    $1f constant DCMIPP_P2CPTACT                \ [0x1f] Active frame capture (active from start-of-frame to frame complete) for Pipe2
  [then]


  [ifdef] DCMIPP_DCMIPP_CMSR2_DEF
    \
    \ @brief DCMIPP common status register 2
    \ Address offset: 0x3F8
    \ Reset value: 0x00000000
    \
    $05 constant DCMIPP_ATXERRF                 \ [0x05] AXI transfer error interrupt status flag for the IPPLUG.
    $06 constant DCMIPP_PRERRF                  \ [0x06] Synchronization error raw interrupt status for the parallel interface.
    $08 constant DCMIPP_P0LINEF                 \ [0x08] Multi-line capture completed raw interrupt status for Pipe0
    $09 constant DCMIPP_P0FRAMEF                \ [0x09] Frame capture completed raw interrupt status for Pipe0
    $0a constant DCMIPP_P0VSYNCF                \ [0x0a] VSYNC raw interrupt status for Pipe0
    $0e constant DCMIPP_P0LIMITF                \ [0x0e] Limit raw interrupt status for Pipe0
    $0f constant DCMIPP_P0OVRF                  \ [0x0f] Overrun raw interrupt status for Pipe0
    $10 constant DCMIPP_P1LINEF                 \ [0x10] Multi-line capture completed raw interrupt status for Pipe1
    $11 constant DCMIPP_P1FRAMEF                \ [0x11] Frame capture completed raw interrupt status for Pipe1
    $12 constant DCMIPP_P1VSYNCF                \ [0x12] VSYNC raw interrupt status for Pipe1
    $17 constant DCMIPP_P1OVRF                  \ [0x17] Overrun raw interrupt status for Pipe1
    $18 constant DCMIPP_P2LINEF                 \ [0x18] Multi-line capture completed raw interrupt status for Pipe2
    $19 constant DCMIPP_P2FRAMEF                \ [0x19] Frame capture completed raw interrupt status for Pipe2
    $1a constant DCMIPP_P2VSYNCF                \ [0x1a] VSYNC raw interrupt status for Pipe2
    $1f constant DCMIPP_P2OVRF                  \ [0x1f] Overrun raw interrupt status for Pipe2
  [then]


  [ifdef] DCMIPP_DCMIPP_CMFCR_DEF
    \
    \ @brief DCMIPP common interrupt clear register
    \ Address offset: 0x3FC
    \ Reset value: 0x00000000
    \
    $05 constant DCMIPP_CATXERRF                \ [0x05] AXI transfer error interrupt status clear
    $06 constant DCMIPP_CPRERRF                 \ [0x06] Synchronization error interrupt status clear
    $08 constant DCMIPP_CP0LINEF                \ [0x08] Multi-line capture complete interrupt status clear
    $09 constant DCMIPP_CP0FRAMEF               \ [0x09] Frame capture complete interrupt status clear
    $0a constant DCMIPP_CP0VSYNCF               \ [0x0a] Vertical synchronization interrupt status clear
    $0e constant DCMIPP_CP0LIMITF               \ [0x0e] limit interrupt status clear
    $0f constant DCMIPP_CP0OVRF                 \ [0x0f] Overrun interrupt status clear
    $10 constant DCMIPP_CP1LINEF                \ [0x10] Multi-line capture complete interrupt status clear
    $11 constant DCMIPP_CP1FRAMEF               \ [0x11] Frame capture complete interrupt status clear
    $12 constant DCMIPP_CP1VSYNCF               \ [0x12] Vertical synchronization interrupt status clear
    $17 constant DCMIPP_CP1OVRF                 \ [0x17] Overrun interrupt status clear
    $18 constant DCMIPP_CP2LINEF                \ [0x18] Multi-line capture complete interrupt status clear
    $19 constant DCMIPP_CP2FRAMEF               \ [0x19] Frame capture complete interrupt status clear
    $1a constant DCMIPP_CP2VSYNCF               \ [0x1a] Vertical synchronization interrupt status clear
    $1f constant DCMIPP_CP2OVRF                 \ [0x1f] Overrun interrupt status clear
  [then]


  [ifdef] DCMIPP_DCMIPP_P0FSCR_DEF
    \
    \ @brief DCMIPP Pipe0 flow selection configuration register
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_DTIDA                   \ [0x00 : 6] Data type selection ID A
    $08 constant DCMIPP_DTIDB                   \ [0x08 : 6] Data type selection ID B
    $10 constant DCMIPP_DTMODE                  \ [0x10 : 2] Flow selection mode
    $13 constant DCMIPP_VC                      \ [0x13 : 2] Flow selection mode
    $1f constant DCMIPP_PIPEN                   \ [0x1f] Activation of PipeN
  [then]


  [ifdef] DCMIPP_DCMIPP_P0FCTCR_DEF
    \
    \ @brief DCMIPP Pipe0 flow control configuration register
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FRATE                   \ [0x00 : 2] Frame capture rate control
    $02 constant DCMIPP_CPTMODE                 \ [0x02] Capture mode
    $03 constant DCMIPP_CPTREQ                  \ [0x03] Capture requested
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
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 word wide (data 32-bit)
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
    $1e constant DCMIPP_POSNEG                  \ [0x1e] This bit is set and cleared by software. It has a meaning only if ENABLE bit is set.
    $1f constant DCMIPP_ENABLE                  \ [0x1f] This bit is set and cleared by software.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0DCCNTR_DEF
    \
    \ @brief DCMIPP Pipe0 dump counter register
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_CNT                     \ [0x00 : 26] Number of data dumped during the frame.
  [then]


  [ifdef] DCMIPP_DCMIPP_P0DCLMTR_DEF
    \
    \ @brief DCMIPP Pipe0 dump limit register
    \ Address offset: 0x5B4
    \ Reset value: 0x00FFFFFF
    \
    $00 constant DCMIPP_LIMIT                   \ [0x00 : 24] Maximum number of 32-bit data that can be dumped during a frame, after the crop 2D operation.
    $1f constant DCMIPP_ENABLE                  \ [0x1f] None
  [then]


  [ifdef] DCMIPP_DCMIPP_P0PPCR_DEF
    \
    \ @brief DCMIPP Pipe0 pixel packer configuration register
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_SWAPYUV                 \ [0x00] Swaps, within a 32-bit word, byte 0-vs-1 and byte 2-vs-3. It corresponds, for YUV422 pixels formats, to swap between UYVY and YUYV.
    $05 constant DCMIPP_PAD                     \ [0x05] Pad mode for monochrome and raw Bayer 10/12/14 bpp: MSB vs. LSB alignment.
    $06 constant DCMIPP_HEADEREN                \ [0x06] CSI header dump enable
    $07 constant DCMIPP_BSM                     \ [0x07 : 2] Byte select mode
    $09 constant DCMIPP_OEBS                    \ [0x09] Odd/even byte select (byte select start)
    $0a constant DCMIPP_LSM                     \ [0x0a] Line select mode
    $0b constant DCMIPP_OELS                    \ [0x0b] Odd/even line select (line select start)
    $0d constant DCMIPP_LINEMULT                \ [0x0d : 3] Amount of capture completed lines for LINE event and interrupt
    $10 constant DCMIPP_DBM                     \ [0x10] Double buffer mode
  [then]


  [ifdef] DCMIPP_DCMIPP_P0PPM0AR1_DEF
    \
    \ @brief DCMIPP Pipe0 pixel packer Memory0 address register 1
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P0PPM0AR2_DEF
    \
    \ @brief DCMIPP Pipe0 pixel packer Memory0 address register 2
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P0STM0AR_DEF
    \
    \ @brief DCMIPP Pipe0 status Memory0 address register
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
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
    $00 constant DCMIPP_LINEF                   \ [0x00] Multi-line capture completed raw interrupt status
    $01 constant DCMIPP_FRAMEF                  \ [0x01] Frame capture completed raw interrupt status
    $02 constant DCMIPP_VSYNCF                  \ [0x02] VSYNC raw interrupt status
    $06 constant DCMIPP_LIMITF                  \ [0x06] Limit raw interrupt status
    $07 constant DCMIPP_OVRF                    \ [0x07] Overrun raw interrupt status
    $10 constant DCMIPP_LSTLINE                 \ [0x10] Last line LSB bit, sampled at frame capture complete event.
    $11 constant DCMIPP_LSTFRM                  \ [0x11] Last frame LSB bit, sampled at frame capture complete event. The information is extracted from the frame data number that can be delivered by the camera through the CSI2 interface.
    $17 constant DCMIPP_CPTACT                  \ [0x17] Capture immediate status
  [then]


  [ifdef] DCMIPP_DCMIPP_P0FCR_DEF
    \
    \ @brief DCMIPP Pipe0 interrupt clear register
    \ Address offset: 0x5FC
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_CLINEF                  \ [0x00] Multi-line capture complete interrupt status clear
    $01 constant DCMIPP_CFRAMEF                 \ [0x01] Frame capture complete interrupt status clear
    $02 constant DCMIPP_CVSYNCF                 \ [0x02] Vertical synchronization interrupt status clear
    $06 constant DCMIPP_CLIMITF                 \ [0x06] limit interrupt status clear
    $07 constant DCMIPP_COVRF                   \ [0x07] Overrun interrupt status clear
  [then]


  [ifdef] DCMIPP_DCMIPP_P0CFSCR_DEF
    \
    \ @brief DCMIPP Pipe0 current flow selection configuration register
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_DTIDA                   \ [0x00 : 6] Current data type selection ID A
    $08 constant DCMIPP_DTIDB                   \ [0x08 : 6] Current data type selection ID B
    $10 constant DCMIPP_DTMODE                  \ [0x10 : 2] Flow selection mode
    $13 constant DCMIPP_VC                      \ [0x13 : 2] Current flow selection mode
    $1f constant DCMIPP_PIPEN                   \ [0x1f] Current activation of PipeN
  [then]


  [ifdef] DCMIPP_DCMIPP_P0CFCTCR_DEF
    \
    \ @brief DCMIPP Pipe0 current flow control configuration register
    \ Address offset: 0x700
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FRATE                   \ [0x00 : 2] Frame capture rate control
    $02 constant DCMIPP_CPTMODE                 \ [0x02] Capture mode
    $03 constant DCMIPP_CPTREQ                  \ [0x03] Capture requested
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
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 word wide (data 32-bit).
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high.
    $1e constant DCMIPP_POSNEG                  \ [0x1e] Current value of the POSNEG bit
    $1f constant DCMIPP_ENABLE                  \ [0x1f] Current value of the ENABLE bit
  [then]


  [ifdef] DCMIPP_DCMIPP_P0CPPCR_DEF
    \
    \ @brief DCMIPP Pipe0 current pixel packer configuration register
    \ Address offset: 0x7C0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_SWAPYUV                 \ [0x00] Swaps, within a 32-bit word, byte 0 vs. 1 and byte 2 vs. 3. It corresponds, for YUV422 pixels formats, to swap between UYVY and YUYV.
    $05 constant DCMIPP_PAD                     \ [0x05] Current Pad mode for monochrome and raw Bayer 10/12/14 bpp: MSB vs. LSB alignment
    $06 constant DCMIPP_HEADEREN                \ [0x06] Current CSI header dump enable
    $07 constant DCMIPP_BSM                     \ [0x07 : 2] Current Byte select mode
    $09 constant DCMIPP_OEBS                    \ [0x09] Current odd/even byte select (byte select start)
    $0a constant DCMIPP_LSM                     \ [0x0a] Current Line select mode
    $0b constant DCMIPP_OELS                    \ [0x0b] Current odd/even line select (ine select start)
    $0d constant DCMIPP_LINEMULT                \ [0x0d : 3] Current amount of capture completed lines for LINE event and interrupt
    $10 constant DCMIPP_DBM                     \ [0x10] Double buffer mode
  [then]


  [ifdef] DCMIPP_DCMIPP_P0CPPM0AR1_DEF
    \
    \ @brief DCMIPP Pipe0 current pixel packer Memory0 address register 1
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P0CPPM0AR2_DEF
    \
    \ @brief DCMIPP Pipe0 current pixel packer Memory0 address register 2
    \ Address offset: 0x7C8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1FSCR_DEF
    \
    \ @brief DCMIPP Pipe1 flow selection configuration register
    \ Address offset: 0x804
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_DTIDA                   \ [0x00 : 6] Data type selection ID A
    $08 constant DCMIPP_DTIDB                   \ [0x08 : 6] Data type selection ID B
    $10 constant DCMIPP_DTMODE                  \ [0x10 : 2] Flow selection mode
    $12 constant DCMIPP_PIPEDIFF                \ [0x12] Differentiates Pipe2 from Pipe1
    $13 constant DCMIPP_VC                      \ [0x13 : 2] Flow selection mode
    $18 constant DCMIPP_FDTF                    \ [0x18 : 6] Force Datatype format.
    $1e constant DCMIPP_FDTFEN                  \ [0x1e] Force Datatype format enable.
    $1f constant DCMIPP_PIPEN                   \ [0x1f] Activation of PipeN
  [then]


  [ifdef] DCMIPP_DCMIPP_P1SRCR_DEF
    \
    \ @brief DCMIPP Pipe1 stat removal configuration register
    \ Address offset: 0x820
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_LASTLINE                \ [0x00 : 12] Amount of following lines to keep when CROPEN = 1. If LASTLINE = 0 all pixels after FIRSTLINEDEL are fed through.
    $0c constant DCMIPP_FIRSTLINEDEL            \ [0x0c : 3] Amount of first lines to delete when CROPEN = 1
    $0f constant DCMIPP_CROPEN                  \ [0x0f] Crop line enable
  [then]


  [ifdef] DCMIPP_DCMIPP_P1BPRCR_DEF
    \
    \ @brief DCMIPP Pipe1 bad pixel removal control register
    \ Address offset: 0x824
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] Bad pixel detection must be enabled only for raw Bayer flows, as it corrupts RGB flows.
    $01 constant DCMIPP_STRENGTH                \ [0x01 : 3] Strength (aggressiveness) of the bad pixel detection
  [then]


  [ifdef] DCMIPP_DCMIPP_P1BPRSR_DEF
    \
    \ @brief DCMIPP Pipe1 bad pixel removal status register
    \ Address offset: 0x828
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_BADCNT                  \ [0x00 : 12] Amount of detected bad pixels
  [then]


  [ifdef] DCMIPP_DCMIPP_P1DECR_DEF
    \
    \ @brief DCMIPP Pipe1 decimation register
    \ Address offset: 0x830
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $01 constant DCMIPP_HDEC                    \ [0x01 : 2] Horizontal decimation ratio
    $03 constant DCMIPP_VDEC                    \ [0x03 : 2] Vertical decimation ratio
  [then]


  [ifdef] DCMIPP_DCMIPP_P1BLCCR_DEF
    \
    \ @brief DCMIPP Pipe1 black level calibration control register
    \ Address offset: 0x840
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] Black level calibration
    $08 constant DCMIPP_BLCB                    \ [0x08 : 8] Black level calibration - Blue
    $10 constant DCMIPP_BLCG                    \ [0x10 : 8] Black level calibration - Green
    $18 constant DCMIPP_BLCR                    \ [0x18 : 8] Black level calibration - Red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1EXCR1_DEF
    \
    \ @brief DCMIPP Pipe1 exposure control register 1
    \ Address offset: 0x844
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] Exposure control (multiplication and shift) of all red, green and blue
    $14 constant DCMIPP_MULTR                   \ [0x14 : 8] Exposure multiplier - Red
    $1c constant DCMIPP_SHFR                    \ [0x1c : 3] Exposure shift - Red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1EXCR2_DEF
    \
    \ @brief DCMIPP Pipe1 exposure control register 2
    \ Address offset: 0x848
    \ Reset value: 0x00000000
    \
    $04 constant DCMIPP_MULTB                   \ [0x04 : 8] Exposure multiplier - Blue
    $0c constant DCMIPP_SHFB                    \ [0x0c : 3] Exposure shift - Blue
    $14 constant DCMIPP_MULTG                   \ [0x14 : 8] Exposure multiplier - Green
    $1c constant DCMIPP_SHFG                    \ [0x1c : 3] Exposure shift - Green
  [then]


  [ifdef] DCMIPP_DCMIPP_P1ST1CR_DEF
    \
    \ @brief DCMIPP Pipe1 statistics1 control register
    \ Address offset: 0x850
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $02 constant DCMIPP_BINS                    \ [0x02 : 2] Current bin definition
    $04 constant DCMIPP_SRC                     \ [0x04 : 3] Statistics source
    $07 constant DCMIPP_MODE                    \ [0x07] Statistics mode
  [then]


  [ifdef] DCMIPP_DCMIPP_P1ST2CR_DEF
    \
    \ @brief DCMIPP Pipe1 statistics 2 control register
    \ Address offset: 0x854
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $02 constant DCMIPP_BINS                    \ [0x02 : 2] Bin definition
    $04 constant DCMIPP_SRC                     \ [0x04 : 3] Statistics source
    $07 constant DCMIPP_MODE                    \ [0x07] Statistics mode
  [then]


  [ifdef] DCMIPP_DCMIPP_P1ST3CR_DEF
    \
    \ @brief DCMIPP Pipe1 statistics 3 control register
    \ Address offset: 0x858
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $02 constant DCMIPP_BINS                    \ [0x02 : 2] Bin definition
    $04 constant DCMIPP_SRC                     \ [0x04 : 3] Statistics source
    $07 constant DCMIPP_MODE                    \ [0x07] Statistics mode
  [then]


  [ifdef] DCMIPP_DCMIPP_P1STSTR_DEF
    \
    \ @brief DCMIPP Pipe1 statistics window start register
    \ Address offset: 0x85C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1STSZR_DEF
    \
    \ @brief DCMIPP Pipe1 statistics window size register
    \ Address offset: 0x860
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
    $1f constant DCMIPP_CROPEN                  \ [0x1f] None
  [then]


  [ifdef] DCMIPP_DCMIPP_P1ST1SR_DEF
    \
    \ @brief DCMIPP Pipe1 statistics 1 status register
    \ Address offset: 0x864
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ACCU                    \ [0x00 : 24] Accumulation result, divided by 256.
  [then]


  [ifdef] DCMIPP_DCMIPP_P1ST2SR_DEF
    \
    \ @brief DCMIPP Pipe1 statistics 2 status register
    \ Address offset: 0x868
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ACCU                    \ [0x00 : 24] accumulation result, divided by 256.
  [then]


  [ifdef] DCMIPP_DCMIPP_P1ST3SR_DEF
    \
    \ @brief DCMIPP Pipe1 statistics 3 status register
    \ Address offset: 0x86C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ACCU                    \ [0x00 : 24] accumulation result, divided by 256.
  [then]


  [ifdef] DCMIPP_DCMIPP_P1DMCR_DEF
    \
    \ @brief DCMIPP Pipe1 demosaicing configuration register
    \ Address offset: 0x870
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $01 constant DCMIPP_TYPE                    \ [0x01 : 2] Raw Bayer type
    $10 constant DCMIPP_PEAK                    \ [0x10 : 3] Strength of the peak detection
    $14 constant DCMIPP_LINEV                   \ [0x14 : 3] Strength of the vertical line detection
    $18 constant DCMIPP_LINEH                   \ [0x18 : 3] Strength of the horizontal line detection
    $1c constant DCMIPP_EDGE                    \ [0x1c : 3] Strength of the edge detection
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCCR_DEF
    \
    \ @brief DCMIPP Pipe1 ColorConv configuration register
    \ Address offset: 0x880
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $01 constant DCMIPP_TYPE                    \ [0x01] output samples type used while CLAMP is activated
    $02 constant DCMIPP_CLAMP                   \ [0x02] Clamp the output samples
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCRR1_DEF
    \
    \ @brief DCMIPP Pipe1 ColorConv red coefficient register 1
    \ Address offset: 0x884
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_RR                      \ [0x00 : 11] Coefficient row 1 column 1 of the matrix
    $10 constant DCMIPP_RG                      \ [0x10 : 11] Coefficient row 1 column 2 of the matrix
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCRR2_DEF
    \
    \ @brief DCMIPP Pipe1 ColorConv red coefficient register 2
    \ Address offset: 0x888
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_RB                      \ [0x00 : 11] Coefficient row 1 column 3 of the matrix
    $10 constant DCMIPP_RA                      \ [0x10 : 10] Coefficient row 1 of the added column (signed integer value)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCGR1_DEF
    \
    \ @brief DCMIPP Pipe1 ColorConv green coefficient register 1
    \ Address offset: 0x88C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_GR                      \ [0x00 : 11] Coefficient row 2 column 1 of the matrix
    $10 constant DCMIPP_GG                      \ [0x10 : 11] Coefficient row 2 column 2 of the matrix
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCGR2_DEF
    \
    \ @brief DCMIPP Pipe1 ColorConv green coefficient register 2
    \ Address offset: 0x890
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_GB                      \ [0x00 : 11] Coefficient row 2 column 3 of the matrix
    $10 constant DCMIPP_GA                      \ [0x10 : 10] Coefficient row 2 of the added column (signed integer value)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCBR1_DEF
    \
    \ @brief DCMIPP Pipex ColorConv blue coefficient register 1
    \ Address offset: 0x894
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_BR                      \ [0x00 : 11] Coefficient row 3 column 1 of the matrix
    $10 constant DCMIPP_BG                      \ [0x10 : 11] Coefficient row 3 column 2 of the matrix
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCBR2_DEF
    \
    \ @brief DCMIPP Pipe1 ColorConv blue coefficient register 2
    \ Address offset: 0x898
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_BB                      \ [0x00 : 11] Coefficient row 3 column 3 of the matrix
    $10 constant DCMIPP_BA                      \ [0x10 : 10] Coefficient row 3 of the added column (signed integer value)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CTCR1_DEF
    \
    \ @brief DCMIPP Pipe1 contrast control register 1
    \ Address offset: 0x8A0
    \ Reset value: 0x00002000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $09 constant DCMIPP_LUM0                    \ [0x09 : 6] Luminance increase for input luminance of 0 (increase is idle with LUMx = 16)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CTCR2_DEF
    \
    \ @brief DCMIPP Pipe1 contrast control register 2
    \ Address offset: 0x8A4
    \ Reset value: 0x20202020
    \
    $01 constant DCMIPP_LUM4                    \ [0x01 : 6] Luminance increase for input luminance of 128 (increase is idle with LUMx = 16)
    $09 constant DCMIPP_LUM3                    \ [0x09 : 6] Luminance increase for input luminance of 96 (increase is idle with LUMx = 16)
    $11 constant DCMIPP_LUM2                    \ [0x11 : 6] Luminance increase for input luminance of 64 (increase is idle with LUMx = 16)
    $19 constant DCMIPP_LUM1                    \ [0x19 : 6] Luminance increase for input luminance of 32 (increase is idle with LUMx = 16)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CTCR3_DEF
    \
    \ @brief DCMIPP Pipe1 contrast control register 3
    \ Address offset: 0x8A8
    \ Reset value: 0x20202020
    \
    $01 constant DCMIPP_LUM8                    \ [0x01 : 6] Luminance increase for input luminance of 256 (increase is idle with LUMx = 16)
    $09 constant DCMIPP_LUM7                    \ [0x09 : 6] Luminance increase for input luminance of 224 (increase is idle with LUMx = 16)
    $11 constant DCMIPP_LUM6                    \ [0x11 : 6] Luminance increase for input luminance of 192 (increase is idle with LUMx = 16)
    $19 constant DCMIPP_LUM5                    \ [0x19 : 6] Luminance increase for input luminance of 160 (increase is idle with LUMx = 16)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1FCTCR_DEF
    \
    \ @brief DCMIPP Pipex flow control configuration register
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FRATE                   \ [0x00 : 2] Frame capture rate control
    $02 constant DCMIPP_CPTMODE                 \ [0x02] Capture mode
    $03 constant DCMIPP_CPTREQ                  \ [0x03] Capture requested
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRSTR_DEF
    \
    \ @brief DCMIPP Pipex crop window start register
    \ Address offset: 0x904
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRSZR_DEF
    \
    \ @brief DCMIPP Pipex crop window size register
    \ Address offset: 0x908
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide. If the value is maintained at 0 when enabling the crop by means of the ENABLE bit, the value is forced internally at 0xFFE, which is the maximum value.
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high. If the value is maintained at 0 when enabling the crop thanks to the ENABLE bit, the value is forced internally at 0xFFE, which is the maximum value.
    $1f constant DCMIPP_ENABLE                  \ [0x1f] None
  [then]


  [ifdef] DCMIPP_DCMIPP_P1DCCR_DEF
    \
    \ @brief DCMIPP Pipex decimation register
    \ Address offset: 0x90C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $01 constant DCMIPP_HDEC                    \ [0x01 : 2] Horizontal decimation ratio
    $03 constant DCMIPP_VDEC                    \ [0x03 : 2] Vertical decimation ratio
  [then]


  [ifdef] DCMIPP_DCMIPP_P1DSCR_DEF
    \
    \ @brief DCMIPP Pipex downsize configuration register
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HDIV                    \ [0x00 : 10] Horizontal division factor, from 128 (8x) to 1023 (1x)
    $10 constant DCMIPP_VDIV                    \ [0x10 : 10] Vertical division factor, from 128 (8x) to 1023 (1x)
    $1f constant DCMIPP_ENABLE                  \ [0x1f] None
  [then]


  [ifdef] DCMIPP_DCMIPP_P1DSRTIOR_DEF
    \
    \ @brief DCMIPP Pipex downsize ratio register
    \ Address offset: 0x914
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HRATIO                  \ [0x00 : 16] Horizontal ratio, from 8192 (1x) to 65535 (8x)
    $10 constant DCMIPP_VRATIO                  \ [0x10 : 16] Vertical ratio, from 8192 (1x) to 65535 (8x)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1DSSZR_DEF
    \
    \ @brief DCMIPP Pipex downsize destination size register
    \ Address offset: 0x918
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CMRICR_DEF
    \
    \ @brief DCMIPP Pipex common ROI configuration register
    \ Address offset: 0x920
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ROILSZ                  \ [0x00 : 2] Region of interest line size width
    $10 constant DCMIPP_ROI1EN                  \ [0x10] Region of interest 1 enable
    $11 constant DCMIPP_ROI2EN                  \ [0x11] Region of interest 2 enable
    $12 constant DCMIPP_ROI3EN                  \ [0x12] Region of interest 3 enable
    $13 constant DCMIPP_ROI4EN                  \ [0x13] Region of interest 4 enable
    $14 constant DCMIPP_ROI5EN                  \ [0x14] Region of interest 5 enable
    $15 constant DCMIPP_ROI6EN                  \ [0x15] Region of interest 6 enable
    $16 constant DCMIPP_ROI7EN                  \ [0x16] Region of interest 7 enable
    $17 constant DCMIPP_ROI8EN                  \ [0x17] Region of interest 8 enable
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI1CR1_DEF
    \
    \ @brief DCMIPP Pipe1 ROI1 configuration register 1
    \ Address offset: 0x924
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI1CR2_DEF
    \
    \ @brief DCMIPP Pipe1 ROI1 configuration register 2
    \ Address offset: 0x928
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI2CR1_DEF
    \
    \ @brief DCMIPP Pipe1 ROI2 configuration register 1
    \ Address offset: 0x92C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI2CR2_DEF
    \
    \ @brief DCMIPP Pipe1 ROI2 configuration register 2
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI3CR1_DEF
    \
    \ @brief DCMIPP Pipe1 ROI3 configuration register 1
    \ Address offset: 0x934
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI3CR2_DEF
    \
    \ @brief DCMIPP Pipe1 ROI3 configuration register 2
    \ Address offset: 0x938
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI4CR1_DEF
    \
    \ @brief DCMIPP Pipe1 ROI4 configuration register 1
    \ Address offset: 0x93C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI4CR2_DEF
    \
    \ @brief DCMIPP Pipe1 ROI4 configuration register 2
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI5CR1_DEF
    \
    \ @brief DCMIPP Pipe1 ROI5 configuration register 1
    \ Address offset: 0x944
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI5CR2_DEF
    \
    \ @brief DCMIPP Pipe1 ROI5 configuration register 2
    \ Address offset: 0x948
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI6CR1_DEF
    \
    \ @brief DCMIPP Pipe1 ROI6 configuration register 1
    \ Address offset: 0x94C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI6CR2_DEF
    \
    \ @brief DCMIPP Pipe1 ROI6 configuration register 2
    \ Address offset: 0x950
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI7CR1_DEF
    \
    \ @brief DCMIPP Pipe1 ROI7 configuration register 1
    \ Address offset: 0x954
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI7CR2_DEF
    \
    \ @brief DCMIPP Pipe1 ROI7 configuration register 2
    \ Address offset: 0x958
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI8CR1_DEF
    \
    \ @brief DCMIPP Pipe1 ROI8 configuration register 1
    \ Address offset: 0x95C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1RI8CR2_DEF
    \
    \ @brief DCMIPP Pipe1 ROI8 configuration register 2
    \ Address offset: 0x960
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1GMCR_DEF
    \
    \ @brief DCMIPP Pipex gamma configuration register
    \ Address offset: 0x970
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
  [then]


  [ifdef] DCMIPP_DCMIPP_P1YUVCR_DEF
    \
    \ @brief DCMIPP Pipe1 YUVConv configuration register
    \ Address offset: 0x980
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $01 constant DCMIPP_TYPE                    \ [0x01] Output samples type used while CLAMP is activated
    $02 constant DCMIPP_CLAMP                   \ [0x02] Clamp the output samples
  [then]


  [ifdef] DCMIPP_DCMIPP_P1YUVRR1_DEF
    \
    \ @brief DCMIPP Pipe1 YUVConv red coefficient register 1
    \ Address offset: 0x984
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_RR                      \ [0x00 : 11] Coefficient row 1 column 1 of the matrix
    $10 constant DCMIPP_RG                      \ [0x10 : 11] Coefficient row 1 column 2 of the matrix
  [then]


  [ifdef] DCMIPP_DCMIPP_P1YUVRR2_DEF
    \
    \ @brief DCMIPP Pipe1 YUVConv red coefficient register 2
    \ Address offset: 0x988
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_RB                      \ [0x00 : 11] Coefficient row 1 column 3 of the matrix
    $10 constant DCMIPP_RA                      \ [0x10 : 10] Coefficient row 1 of the added column (signed integer value)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1YUVGR1_DEF
    \
    \ @brief DCMIPP Pipe1 YUVConv green coefficient register 1
    \ Address offset: 0x98C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_GR                      \ [0x00 : 11] Coefficient row 2 column 1 of the matrix
    $10 constant DCMIPP_GG                      \ [0x10 : 11] Coefficient row 2 column 2 of the matrix
  [then]


  [ifdef] DCMIPP_DCMIPP_P1YUVGR2_DEF
    \
    \ @brief DCMIPP Pipe1 YUVConv green coefficient register 2
    \ Address offset: 0x990
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_GB                      \ [0x00 : 11] Coefficient row 2 column 3 of the matrix
    $10 constant DCMIPP_GA                      \ [0x10 : 10] Coefficient row 2 of the added column (signed integer value)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1YUVBR1_DEF
    \
    \ @brief DCMIPP Pipe1 YUVConv blue coefficient register 1
    \ Address offset: 0x994
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_BR                      \ [0x00 : 11] Coefficient row 3 column 1 of the matrix
    $10 constant DCMIPP_BG                      \ [0x10 : 11] Coefficient row 3 column 2 of the matrix
  [then]


  [ifdef] DCMIPP_DCMIPP_P1YUVBR2_DEF
    \
    \ @brief DCMIPP Pipe1 YUV blue coefficient register 2
    \ Address offset: 0x998
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_BB                      \ [0x00 : 11] Coefficient row 3 column 3 of the matrix
    $10 constant DCMIPP_BA                      \ [0x10 : 10] Coefficient row 3 of the added column (signed integer value)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1PPCR_DEF
    \
    \ @brief DCMIPP Pipe1 pixel packer configuration register
    \ Address offset: 0x9C0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FORMAT                  \ [0x00 : 4] Memory format
    $04 constant DCMIPP_SWAPRB                  \ [0x04] Swaps R-vs-B components if RGB, and U-vs-V components if YUV
    $0d constant DCMIPP_LINEMULT                \ [0x0d : 3] Amount of capture completed lines for LINE Event and Interrupt
    $10 constant DCMIPP_DBM                     \ [0x10] Double buffer mode
    $11 constant DCMIPP_LMAWM                   \ [0x11 : 3] Line multi address wrapping modulo.
    $14 constant DCMIPP_LMAWE                   \ [0x14] Line multi address wrapping enable bit.
  [then]


  [ifdef] DCMIPP_DCMIPP_P1PPM0AR1_DEF
    \
    \ @brief DCMIPP Pipe1 pixel packer Memory0 address register 1
    \ Address offset: 0x9C4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1PPM0AR2_DEF
    \
    \ @brief DCMIPP Pipe1 pixel packer Memory0 address register 2
    \ Address offset: 0x9C8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1PPM0PR_DEF
    \
    \ @brief DCMIPP Pipex pixel packer Memory0 pitch register
    \ Address offset: 0x9CC
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_PITCH                   \ [0x00 : 15] Number of bytes between the address of two consecutive lines.
  [then]


  [ifdef] DCMIPP_DCMIPP_P1STM0AR_DEF
    \
    \ @brief DCMIPP Pipex status Memory0 address register
    \ Address offset: 0x9D0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1PPM1AR1_DEF
    \
    \ @brief DCMIPP Pipex pixel packer Memory1 address register 1
    \ Address offset: 0x9D4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M1A                     \ [0x00 : 32] Memory1 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1PPM1AR2_DEF
    \
    \ @brief DCMIPP Pipex pixel packer Memory1 address register 2
    \ Address offset: 0x9D8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M1A                     \ [0x00 : 32] Memory1 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1PPM1PR_DEF
    \
    \ @brief DCMIPP Pipex pixel packer Memory1 pitch register
    \ Address offset: 0x9DC
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_PITCH                   \ [0x00 : 15] Number of bytes between the address of two consecutive lines.
  [then]


  [ifdef] DCMIPP_DCMIPP_P1STM1AR_DEF
    \
    \ @brief DCMIPP Pipex status Memory1 address register
    \ Address offset: 0x9E0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M1A                     \ [0x00 : 32] Memory1 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1PPM2AR1_DEF
    \
    \ @brief DCMIPP Pipex pixel packer memory2 address register 1
    \ Address offset: 0x9E4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M2A                     \ [0x00 : 32] Memory 2 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1PPM2AR2_DEF
    \
    \ @brief DCMIPP Pipex pixel packer memory2 address register 2
    \ Address offset: 0x9E8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M2A                     \ [0x00 : 32] Memory 2 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1STM2AR_DEF
    \
    \ @brief DCMIPP Pipex status Memory2 address register
    \ Address offset: 0x9F0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M2A                     \ [0x00 : 32] Memory2 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1IER_DEF
    \
    \ @brief DCMIPP Pipe1 interrupt enable register
    \ Address offset: 0x9F4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_LINEIE                  \ [0x00] Multi-line capture completed interrupt enable
    $01 constant DCMIPP_FRAMEIE                 \ [0x01] Frame capture completed interrupt enable
    $02 constant DCMIPP_VSYNCIE                 \ [0x02] VSYNC interrupt enable
    $07 constant DCMIPP_OVRIE                   \ [0x07] Overrun interrupt enable
  [then]


  [ifdef] DCMIPP_DCMIPP_P1SR_DEF
    \
    \ @brief DCMIPP Pipe1 status register
    \ Address offset: 0x9F8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_LINEF                   \ [0x00] Multi-line capture completed raw interrupt status
    $01 constant DCMIPP_FRAMEF                  \ [0x01] Frame capture completed raw interrupt status
    $02 constant DCMIPP_VSYNCF                  \ [0x02] VSYNC raw interrupt status
    $07 constant DCMIPP_OVRF                    \ [0x07] Overrun raw interrupt status
    $10 constant DCMIPP_LSTLINE                 \ [0x10] Last line LSB bit, sampled at frame capture complete event.
    $11 constant DCMIPP_LSTFRM                  \ [0x11] Last frame LSB bit, sampled at frame capture complete event. The information is extracted from the frame data number, which can be delivered by the camera through the CSI2 interface.
    $17 constant DCMIPP_CPTACT                  \ [0x17] Capture immediate status
  [then]


  [ifdef] DCMIPP_DCMIPP_P1FCR_DEF
    \
    \ @brief DCMIPP Pipe1 interrupt clear register
    \ Address offset: 0x9FC
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_CLINEF                  \ [0x00] Multi-line capture complete interrupt status clear
    $01 constant DCMIPP_CFRAMEF                 \ [0x01] Frame capture complete interrupt status clear
    $02 constant DCMIPP_CVSYNCF                 \ [0x02] Vertical synchronization interrupt status clear
    $07 constant DCMIPP_COVRF                   \ [0x07] Overrun interrupt status clear
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CFSCR_DEF
    \
    \ @brief DCMIPP Pipe1 current flow selection configuration register
    \ Address offset: 0xA04
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_DTIDA                   \ [0x00 : 6] Current data type ID A
    $08 constant DCMIPP_DTIDB                   \ [0x08 : 6] Current data type ID B
    $10 constant DCMIPP_DTMODE                  \ [0x10 : 2] Flow selection mode
    $12 constant DCMIPP_PIPEDIFF                \ [0x12] Current differentiates Pipe2 vs. Pipe1
    $13 constant DCMIPP_VC                      \ [0x13 : 2] Current flow selection mode
    $18 constant DCMIPP_FDTF                    \ [0x18 : 6] Current force data type format
    $1e constant DCMIPP_FDTFEN                  \ [0x1e] Current force data type format enable
    $1f constant DCMIPP_PIPEN                   \ [0x1f] Current activation of PipeN
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CBPRCR_DEF
    \
    \ @brief DCMIPP Pipe1 current bad pixel removal register
    \ Address offset: 0xA24
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] Current status of enable bit
    $01 constant DCMIPP_STRENGTH                \ [0x01 : 3] Current strength (aggressiveness) of the bad pixel detection:
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CBLCCR_DEF
    \
    \ @brief DCMIPP Pipe1 current black level calibration control register
    \ Address offset: 0xA40
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] For current black level calibration
    $08 constant DCMIPP_BLCB                    \ [0x08 : 8] Current black level calibration - Blue
    $10 constant DCMIPP_BLCG                    \ [0x10 : 8] Current black level calibration - Green
    $18 constant DCMIPP_BLCR                    \ [0x18 : 8] Current black level calibration - Red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CEXCR1_DEF
    \
    \ @brief DCMIPP Pipe1 current exposure control register 1
    \ Address offset: 0xA44
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] for exposure control (multiplication and shift)
    $14 constant DCMIPP_MULTR                   \ [0x14 : 8] Current exposure multiplier - Red
    $1c constant DCMIPP_SHFR                    \ [0x1c : 3] Current exposure shift - Red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CEXCR2_DEF
    \
    \ @brief DCMIPP Pipe1 current exposure control register 2
    \ Address offset: 0xA48
    \ Reset value: 0x00000000
    \
    $04 constant DCMIPP_MULTB                   \ [0x04 : 8] Current exposure multiplier - Blue
    $0c constant DCMIPP_SHFB                    \ [0x0c : 3] Current exposure shift - Blue
    $14 constant DCMIPP_MULTG                   \ [0x14 : 8] Current exposure multiplier - Green
    $1c constant DCMIPP_SHFG                    \ [0x1c : 3] Current exposure shift - Green
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CST1CR_DEF
    \
    \ @brief DCMIPP Pipe1 current statistics 1 control register
    \ Address offset: 0xA50
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] Current enable bit value
    $02 constant DCMIPP_BINS                    \ [0x02 : 2] Current bin definition
    $04 constant DCMIPP_SRC                     \ [0x04 : 3] Current source of statistics
    $07 constant DCMIPP_MODE                    \ [0x07] Current statistics mode
    $08 constant DCMIPP_ACCU                    \ [0x08 : 24] Current accumulation result, divided by 256.
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CST2CR_DEF
    \
    \ @brief DCMIPP Pipe1 current statistics 2 control register
    \ Address offset: 0xA54
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $02 constant DCMIPP_BINS                    \ [0x02 : 2] Bin definition
    $04 constant DCMIPP_SRC                     \ [0x04 : 3] Statistics source
    $07 constant DCMIPP_MODE                    \ [0x07] Statistics mode
    $08 constant DCMIPP_ACCU                    \ [0x08 : 24] Accumulation result, divided by 256.
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CST3CR_DEF
    \
    \ @brief DCMIPP Pipe1 current statistics 3 control register
    \ Address offset: 0xA58
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $02 constant DCMIPP_BINS                    \ [0x02 : 2] Current bin definition
    $04 constant DCMIPP_SRC                     \ [0x04 : 3] Statistics source
    $07 constant DCMIPP_MODE                    \ [0x07] Statistics mode
    $08 constant DCMIPP_ACCU                    \ [0x08 : 24] Accumulation result, divided by 256.
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CSTSTR_DEF
    \
    \ @brief DCMIPP Pipe1 current statistics window start register
    \ Address offset: 0xA5C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CSTSZR_DEF
    \
    \ @brief DCMIPP Pipe1 current statistics window size register
    \ Address offset: 0xA60
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
    $1f constant DCMIPP_CROPEN                  \ [0x1f] Current CROPEN bit value
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCCCR_DEF
    \
    \ @brief DCMIPP Pipe1 current ColorConv configuration register
    \ Address offset: 0xA80
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] Current value applied
    $01 constant DCMIPP_TYPE                    \ [0x01] Output samples type used while CLAMP is activated
    $02 constant DCMIPP_CLAMP                   \ [0x02] Clamp the output samples
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCCRR1_DEF
    \
    \ @brief DCMIPP Pipe1 current ColorConv red coefficient register 1
    \ Address offset: 0xA84
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_RR                      \ [0x00 : 11] Current coefficient row 1 column 1 of the matrix
    $10 constant DCMIPP_RG                      \ [0x10 : 11] Current coefficient row 1 column 2 of the matrix
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCCRR2_DEF
    \
    \ @brief DCMIPP Pipe1 current ColorConv red coefficient register 2
    \ Address offset: 0xA88
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_RB                      \ [0x00 : 11] Current coefficient row 1 column 3 of the matrix
    $10 constant DCMIPP_RA                      \ [0x10 : 10] Current coefficient row 1 of the added column (signed integer value)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCCGR1_DEF
    \
    \ @brief DCMIPP Pipe1 current ColorConv green coefficient register 1
    \ Address offset: 0xA8C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_GR                      \ [0x00 : 11] Current coefficient row 2 column 1 of the matrix
    $10 constant DCMIPP_GG                      \ [0x10 : 11] Current coefficient row 2 column 2 of the matrix
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCCGR2_DEF
    \
    \ @brief DCMIPP Pipe1 current ColorConv green coefficient register 2
    \ Address offset: 0xA90
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_GB                      \ [0x00 : 11] Current coefficient row 2 column 3 of the matrix
    $10 constant DCMIPP_GA                      \ [0x10 : 10] Current coefficient row 2 of the added column (signed integer value)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCCBR1_DEF
    \
    \ @brief DCMIPP Pipex current ColorConv blue coefficient register 1
    \ Address offset: 0xA94
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_BR                      \ [0x00 : 11] Current coefficient row 3 column 1 of the matrix
    $10 constant DCMIPP_BG                      \ [0x10 : 11] Current coefficient row 3 column 2 of the matrix
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCCBR2_DEF
    \
    \ @brief DCMIPP Pipe1 current ColorConv blue coefficient register 2
    \ Address offset: 0xA98
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_BB                      \ [0x00 : 11] Current coefficient row 3 column 3 of the matrix
    $10 constant DCMIPP_BA                      \ [0x10 : 10] Current coefficient row 3 of the added column (signed integer value)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCTCR1_DEF
    \
    \ @brief DCMIPP Pipe1 current contrast control register 1
    \ Address offset: 0xAA0
    \ Reset value: 0x00002000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] Current ENABLE bit value
    $09 constant DCMIPP_LUM0                    \ [0x09 : 6] Current luminance increase for input luminance of 0 (increase is idle with LUMx = 16)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCTCR2_DEF
    \
    \ @brief DCMIPP Pipe1 current contrast control register 2
    \ Address offset: 0xAA4
    \ Reset value: 0x20202020
    \
    $01 constant DCMIPP_LUM4                    \ [0x01 : 6] Current luminance increase for input luminance of 128 (increase is idle with LUMx = 16)
    $09 constant DCMIPP_LUM3                    \ [0x09 : 6] Current luminance increase for input luminance of 96 (increase is idle with LUMx = 16)
    $11 constant DCMIPP_LUM2                    \ [0x11 : 6] Current luminance increase for input luminance of 64 (increase is idle with LUMx = 16)
    $19 constant DCMIPP_LUM1                    \ [0x19 : 6] Current luminance increase for input luminance of 32 (increase is idle with LUMx = 16)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCTCR3_DEF
    \
    \ @brief DCMIPP Pipe1 current contrast control register 3
    \ Address offset: 0xAA8
    \ Reset value: 0x20202020
    \
    $01 constant DCMIPP_LUM8                    \ [0x01 : 6] Luminance increase for input luminance of 256 (increase is idle with LUMx = 16)
    $09 constant DCMIPP_LUM7                    \ [0x09 : 6] Luminance increase for input luminance of 224 (increase is idle with LUMx = 16)
    $11 constant DCMIPP_LUM6                    \ [0x11 : 6] Luminance increase for input luminance of 192 (increase is idle with LUMx = 16)
    $19 constant DCMIPP_LUM5                    \ [0x19 : 6] Luminance increase for input luminance of 160 (increase is idle with LUMx = 16)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CFCTCR_DEF
    \
    \ @brief DCMIPP Pipex current flow control configuration register
    \ Address offset: 0xB00
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FRATE                   \ [0x00 : 2] Frame capture rate control
    $02 constant DCMIPP_CPTMODE                 \ [0x02] Capture mode
    $03 constant DCMIPP_CPTREQ                  \ [0x03] Capture requested
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCRSTR_DEF
    \
    \ @brief DCMIPP Pipex current crop window start register
    \ Address offset: 0xB04
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCRSZR_DEF
    \
    \ @brief DCMIPP Pipex current crop window size register
    \ Address offset: 0xB08
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
    $1f constant DCMIPP_ENABLE                  \ [0x1f] Current ENABLE bit value.
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CDCCR_DEF
    \
    \ @brief DCMIPP Pipex current decimation register
    \ Address offset: 0xB0C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $01 constant DCMIPP_HDEC                    \ [0x01 : 2] Horizontal decimation ratio
    $03 constant DCMIPP_VDEC                    \ [0x03 : 2] Vertical decimation ratio
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CDSCR_DEF
    \
    \ @brief DCMIPP Pipex current downsize configuration register
    \ Address offset: 0xB10
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HDIV                    \ [0x00 : 10] Current horizontal division factor, from 128 (8x) to 1023 (1x)
    $10 constant DCMIPP_VDIV                    \ [0x10 : 10] Current vertical division factor, from 128 (8x) to 1023 (1x)
    $1f constant DCMIPP_ENABLE                  \ [0x1f] Current value of bit ENABLE
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CDSRTIOR_DEF
    \
    \ @brief DCMIPP Pipex current downsize ratio register
    \ Address offset: 0xB14
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HRATIO                  \ [0x00 : 16] Current horizontal ratio, from 8192 (1x) to 65535 (8x)
    $10 constant DCMIPP_VRATIO                  \ [0x10 : 16] Current vertical ratio, from 8192 (1x) to 65535 (8x)
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CDSSZR_DEF
    \
    \ @brief DCMIPP Pipex current downsize destination size register
    \ Address offset: 0xB18
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CCMRICR_DEF
    \
    \ @brief DCMIPP Pipex current common ROI configuration register
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ROILSZ                  \ [0x00 : 2] Current region of interest line size width
    $10 constant DCMIPP_ROI1EN                  \ [0x10] Current region of interest 1 enable
    $11 constant DCMIPP_ROI2EN                  \ [0x11] Current region of interest 2 enable
    $12 constant DCMIPP_ROI3EN                  \ [0x12] Current region of interest 3 enable
    $13 constant DCMIPP_ROI4EN                  \ [0x13] Current region of interest 4 enable
    $14 constant DCMIPP_ROI5EN                  \ [0x14] Current region of interest 5 enable
    $15 constant DCMIPP_ROI6EN                  \ [0x15] Current region of interest 6 enable
    $16 constant DCMIPP_ROI7EN                  \ [0x16] Current region of interest 7 enable
    $17 constant DCMIPP_ROI8EN                  \ [0x17] Current region of interest 8 enable
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI1CR1_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI1 configuration register 1
    \ Address offset: 0xB24
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI1CR2_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI1 configuration register 2
    \ Address offset: 0xB28
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI2CR1_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI2 configuration register 1
    \ Address offset: 0xB2C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI2CR2_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI2 configuration register 2
    \ Address offset: 0xB30
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI3CR1_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI3 configuration register 1
    \ Address offset: 0xB34
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI3CR2_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI3 configuration register 2
    \ Address offset: 0xB38
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI4CR1_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI4 configuration register 1
    \ Address offset: 0xB3C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI4CR2_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI4 configuration register 2
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI5CR1_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI5 configuration register 1
    \ Address offset: 0xB44
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI5CR2_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI5 configuration register 2
    \ Address offset: 0xB48
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI6CR1_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI6 configuration register 1
    \ Address offset: 0xB4C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI6CR2_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI6 configuration register 2
    \ Address offset: 0xB50
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI7CR1_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI7 configuration register 1
    \ Address offset: 0xB54
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI7CR2_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI7 configuration register 2
    \ Address offset: 0xB58
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI8CR1_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI8 configuration register 1
    \ Address offset: 0xB5C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CRI8CR2_DEF
    \
    \ @brief DCMIPP Pipe1 current ROI8 configuration register 2
    \ Address offset: 0xB60
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CPPCR_DEF
    \
    \ @brief DCMIPP Pipe1 current pixel packer configuration register
    \ Address offset: 0xBC0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FORMAT                  \ [0x00 : 4] Memory format
    $04 constant DCMIPP_SWAPRB                  \ [0x04] Swaps R-vs-B components if RGB, and U-vs-V components if YUV
    $0d constant DCMIPP_LINEMULT                \ [0x0d : 3] Amount of capture completed lines for LINE Event and Interrupt
    $10 constant DCMIPP_DBM                     \ [0x10] Double buffer mode
    $11 constant DCMIPP_LMAWM                   \ [0x11 : 3] Line multi address wrapping modulo
    $14 constant DCMIPP_LMAWE                   \ [0x14] Line multi address wrapping enable bit
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CPPM0AR1_DEF
    \
    \ @brief DCMIPP Pipe1 current pixel packer Memory0 address register 1
    \ Address offset: 0xBC4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CPPM0AR2_DEF
    \
    \ @brief DCMIPP Pipe1 current pixel packer Memory0 address register 2
    \ Address offset: 0xBC8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CPPM0PR_DEF
    \
    \ @brief DCMIPP Pipex current pixel packer Memory0 pitch register
    \ Address offset: 0xBCC
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_PITCH                   \ [0x00 : 15] Current number of bytes between the address of two consecutive lines.
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CPPM1AR1_DEF
    \
    \ @brief DCMIPP Pipex current pixel packer Memory1 address register 1
    \ Address offset: 0xBD4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M1A                     \ [0x00 : 32] Memory1 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CPPM1AR2_DEF
    \
    \ @brief DCMIPP Pipex current pixel packer Memory1 address register 2
    \ Address offset: 0xBD8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M1A                     \ [0x00 : 32] Memory1 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CPPM1PR_DEF
    \
    \ @brief DCMIPP Pipex current pixel packer Memory1 pitch register
    \ Address offset: 0xBDC
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_PITCH                   \ [0x00 : 15] Current number of bytes between the address of two consecutive lines
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CPPM2AR1_DEF
    \
    \ @brief DCMIPP Pipex current pixel packer Memory2 address register 1
    \ Address offset: 0xBE4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M2A                     \ [0x00 : 32] Memory 2 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P1CPPM2AR2_DEF
    \
    \ @brief DCMIPP Pipex current pixel packer Memory2 address register 1
    \ Address offset: 0xBE8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M2A                     \ [0x00 : 32] Memory 2 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P2FSCR_DEF
    \
    \ @brief DCMIPP Pipe2 flow selection configuration register
    \ Address offset: 0xC04
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_DTIDA                   \ [0x00 : 6] Data type ID
    $13 constant DCMIPP_VC                      \ [0x13 : 2] Flow selection mode
    $18 constant DCMIPP_FDTF                    \ [0x18 : 6] Force data type format
    $1e constant DCMIPP_FDTFEN                  \ [0x1e] Force data type format enable
    $1f constant DCMIPP_PIPEN                   \ [0x1f] Activation of PipeN
  [then]


  [ifdef] DCMIPP_DCMIPP_P2FCTCR_DEF
    \
    \ @brief DCMIPP Pipex flow control configuration register
    \ Address offset: 0xD00
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FRATE                   \ [0x00 : 2] Frame capture rate control
    $02 constant DCMIPP_CPTMODE                 \ [0x02] Capture mode
    $03 constant DCMIPP_CPTREQ                  \ [0x03] Capture requested
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRSTR_DEF
    \
    \ @brief DCMIPP Pipex crop window start register
    \ Address offset: 0xD04
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRSZR_DEF
    \
    \ @brief DCMIPP Pipex crop window size register
    \ Address offset: 0xD08
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide. If the value is maintained at 0 when enabling the crop by means of the ENABLE bit, the value is forced internally at 0xFFE, which is the maximum value.
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high. If the value is maintained at 0 when enabling the crop thanks to the ENABLE bit, the value is forced internally at 0xFFE, which is the maximum value.
    $1f constant DCMIPP_ENABLE                  \ [0x1f] None
  [then]


  [ifdef] DCMIPP_DCMIPP_P2DCCR_DEF
    \
    \ @brief DCMIPP Pipex decimation register
    \ Address offset: 0xD0C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $01 constant DCMIPP_HDEC                    \ [0x01 : 2] Horizontal decimation ratio
    $03 constant DCMIPP_VDEC                    \ [0x03 : 2] Vertical decimation ratio
  [then]


  [ifdef] DCMIPP_DCMIPP_P2DSCR_DEF
    \
    \ @brief DCMIPP Pipex downsize configuration register
    \ Address offset: 0xD10
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HDIV                    \ [0x00 : 10] Horizontal division factor, from 128 (8x) to 1023 (1x)
    $10 constant DCMIPP_VDIV                    \ [0x10 : 10] Vertical division factor, from 128 (8x) to 1023 (1x)
    $1f constant DCMIPP_ENABLE                  \ [0x1f] None
  [then]


  [ifdef] DCMIPP_DCMIPP_P2DSRTIOR_DEF
    \
    \ @brief DCMIPP Pipex downsize ratio register
    \ Address offset: 0xD14
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HRATIO                  \ [0x00 : 16] Horizontal ratio, from 8192 (1x) to 65535 (8x)
    $10 constant DCMIPP_VRATIO                  \ [0x10 : 16] Vertical ratio, from 8192 (1x) to 65535 (8x)
  [then]


  [ifdef] DCMIPP_DCMIPP_P2DSSZR_DEF
    \
    \ @brief DCMIPP Pipex downsize destination size register
    \ Address offset: 0xD18
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CMRICR_DEF
    \
    \ @brief DCMIPP Pipex common ROI configuration register
    \ Address offset: 0xD20
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ROILSZ                  \ [0x00 : 2] Region of interest line size width
    $10 constant DCMIPP_ROI1EN                  \ [0x10] Region of interest 1 enable
    $11 constant DCMIPP_ROI2EN                  \ [0x11] Region of interest 2 enable
    $12 constant DCMIPP_ROI3EN                  \ [0x12] Region of interest 3 enable
    $13 constant DCMIPP_ROI4EN                  \ [0x13] Region of interest 4 enable
    $14 constant DCMIPP_ROI5EN                  \ [0x14] Region of interest 5 enable
    $15 constant DCMIPP_ROI6EN                  \ [0x15] Region of interest 6 enable
    $16 constant DCMIPP_ROI7EN                  \ [0x16] Region of interest 7 enable
    $17 constant DCMIPP_ROI8EN                  \ [0x17] Region of interest 8 enable
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI1CR1_DEF
    \
    \ @brief DCMIPP Pipe2 ROI1 configuration register 1
    \ Address offset: 0xD24
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI1CR2_DEF
    \
    \ @brief DCMIPP Pipe2 ROI1 configuration register 2
    \ Address offset: 0xD28
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI2CR1_DEF
    \
    \ @brief DCMIPP Pipe2 ROI2 configuration register 1
    \ Address offset: 0xD2C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI2CR2_DEF
    \
    \ @brief DCMIPP Pipe2 ROI2 configuration register 2
    \ Address offset: 0xD30
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI3CR1_DEF
    \
    \ @brief DCMIPP Pipe2 ROI3 configuration register 1
    \ Address offset: 0xD34
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI3CR2_DEF
    \
    \ @brief DCMIPP Pipe2 ROI3 configuration register 2
    \ Address offset: 0xD38
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI4CR1_DEF
    \
    \ @brief DCMIPP Pipe2 ROI4 configuration register 1
    \ Address offset: 0xD3C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI4CR2_DEF
    \
    \ @brief DCMIPP Pipe2 ROI4 configuration register 2
    \ Address offset: 0xD40
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI5CR1_DEF
    \
    \ @brief DCMIPP Pipe2 ROI5 configuration register 1
    \ Address offset: 0xD44
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI5CR2_DEF
    \
    \ @brief DCMIPP Pipe2 ROI5 configuration register 2
    \ Address offset: 0xD48
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI6CR1_DEF
    \
    \ @brief DCMIPP Pipe2 ROI6 configuration register 1
    \ Address offset: 0xD4C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI6CR2_DEF
    \
    \ @brief DCMIPP Pipe2 ROI6 configuration register 2
    \ Address offset: 0xD50
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI7CR1_DEF
    \
    \ @brief DCMIPP Pipe2 ROI7 configuration register 1
    \ Address offset: 0xD54
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI7CR2_DEF
    \
    \ @brief DCMIPP Pipe2 ROI7 configuration register 2
    \ Address offset: 0xD58
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI8CR1_DEF
    \
    \ @brief DCMIPP Pipe2 ROI8 configuration register 1
    \ Address offset: 0xD5C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2RI8CR2_DEF
    \
    \ @brief DCMIPP Pipe2 ROI8 configuration register 2
    \ Address offset: 0xD60
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2GMCR_DEF
    \
    \ @brief DCMIPP Pipex gamma configuration register
    \ Address offset: 0xD70
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
  [then]


  [ifdef] DCMIPP_DCMIPP_P2PPCR_DEF
    \
    \ @brief DCMIPP Pipe2 pixel packer configuration register
    \ Address offset: 0xDC0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FORMAT                  \ [0x00 : 4] Memory format (only coplanar formats are supported in Pipe2)
    $04 constant DCMIPP_SWAPRB                  \ [0x04] Swaps R-vs-B components if RGB, and if YUV, swaps U-vs-V components
    $0d constant DCMIPP_LINEMULT                \ [0x0d : 3] Amount of capture completed lines for LINE event and interrupt
    $10 constant DCMIPP_DBM                     \ [0x10] Double buffer mode
    $11 constant DCMIPP_LMAWM                   \ [0x11 : 3] Line multi address wrapping modulo
    $14 constant DCMIPP_LMAWE                   \ [0x14] Line multi address wrapping enable bit
  [then]


  [ifdef] DCMIPP_DCMIPP_P2PPM0AR1_DEF
    \
    \ @brief DCMIPP Pipe2 pixel packer Memory0 address register 1
    \ Address offset: 0xDC4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P2PPM0AR2_DEF
    \
    \ @brief DCMIPP Pipe2 pixel packer Memory0 address register 2
    \ Address offset: 0xDC8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P2PPM0PR_DEF
    \
    \ @brief DCMIPP Pipex pixel packer Memory0 pitch register
    \ Address offset: 0xDCC
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_PITCH                   \ [0x00 : 15] Number of bytes between the address of two consecutive lines.
  [then]


  [ifdef] DCMIPP_DCMIPP_P2STM0AR_DEF
    \
    \ @brief DCMIPP Pipex status Memory0 address register
    \ Address offset: 0xDD0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P2IER_DEF
    \
    \ @brief DCMIPP Pipe2 interrupt enable register
    \ Address offset: 0xDF4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_LINEIE                  \ [0x00] Multi-line capture completed interrupt enable
    $01 constant DCMIPP_FRAMEIE                 \ [0x01] Frame capture completed interrupt enable
    $02 constant DCMIPP_VSYNCIE                 \ [0x02] VSYNC interrupt enable
    $07 constant DCMIPP_OVRIE                   \ [0x07] Overrun interrupt enable
  [then]


  [ifdef] DCMIPP_DCMIPP_P2SR_DEF
    \
    \ @brief DCMIPP Pipe2 status register
    \ Address offset: 0xDF8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_LINEF                   \ [0x00] Multi-line capture completed raw interrupt status
    $01 constant DCMIPP_FRAMEF                  \ [0x01] Frame capture completed raw interrupt status
    $02 constant DCMIPP_VSYNCF                  \ [0x02] VSYNC raw interrupt status
    $07 constant DCMIPP_OVRF                    \ [0x07] Overrun raw interrupt status
    $10 constant DCMIPP_LSTLINE                 \ [0x10] Last line LSB bit, sampled at frame capture complete event.
    $11 constant DCMIPP_LSTFRM                  \ [0x11] Last frame LSB bit, sampled at frame capture complete event. The information is extracted from the frame data number which can be delivered by the camera through the CSI2 interface.
    $17 constant DCMIPP_CPTACT                  \ [0x17] Capture immediate status
  [then]


  [ifdef] DCMIPP_DCMIPP_P2FCR_DEF
    \
    \ @brief DCMIPP Pipe2 interrupt clear register
    \ Address offset: 0xDFC
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_CLINEF                  \ [0x00] Multi-line capture complete interrupt status clear
    $01 constant DCMIPP_CFRAMEF                 \ [0x01] Frame capture complete interrupt status clear
    $02 constant DCMIPP_CVSYNCF                 \ [0x02] Vertical synchronization interrupt status clear
    $07 constant DCMIPP_COVRF                   \ [0x07] Overrun interrupt status clear
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CFSCR_DEF
    \
    \ @brief DCMIPP Pipe2 current flow selection configuration register
    \ Address offset: 0xE04
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_DTIDA                   \ [0x00 : 6] Current data type ID
    $13 constant DCMIPP_VC                      \ [0x13 : 2] Current flow selection mode
    $18 constant DCMIPP_FDTF                    \ [0x18 : 6] Current force data type format
    $1e constant DCMIPP_FDTFEN                  \ [0x1e] Current force data type format enable
    $1f constant DCMIPP_PIPEN                   \ [0x1f] Current activation of PipeN
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CFCTCR_DEF
    \
    \ @brief DCMIPP Pipex current flow control configuration register
    \ Address offset: 0xF00
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FRATE                   \ [0x00 : 2] Frame capture rate control
    $02 constant DCMIPP_CPTMODE                 \ [0x02] Capture mode
    $03 constant DCMIPP_CPTREQ                  \ [0x03] Capture requested
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CCRSTR_DEF
    \
    \ @brief DCMIPP Pipex current crop window start register
    \ Address offset: 0xF04
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CCRSZR_DEF
    \
    \ @brief DCMIPP Pipex current crop window size register
    \ Address offset: 0xF08
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
    $1f constant DCMIPP_ENABLE                  \ [0x1f] Current ENABLE bit value.
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CDCCR_DEF
    \
    \ @brief DCMIPP Pipex current decimation register
    \ Address offset: 0xF0C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ENABLE                  \ [0x00] None
    $01 constant DCMIPP_HDEC                    \ [0x01 : 2] Horizontal decimation ratio
    $03 constant DCMIPP_VDEC                    \ [0x03 : 2] Vertical decimation ratio
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CDSCR_DEF
    \
    \ @brief DCMIPP Pipex current downsize configuration register
    \ Address offset: 0xF10
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HDIV                    \ [0x00 : 10] Current horizontal division factor, from 128 (8x) to 1023 (1x)
    $10 constant DCMIPP_VDIV                    \ [0x10 : 10] Current vertical division factor, from 128 (8x) to 1023 (1x)
    $1f constant DCMIPP_ENABLE                  \ [0x1f] Current value of bit ENABLE
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CDSRTIOR_DEF
    \
    \ @brief DCMIPP Pipex current downsize ratio register
    \ Address offset: 0xF14
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HRATIO                  \ [0x00 : 16] Current horizontal ratio, from 8192 (1x) to 65535 (8x)
    $10 constant DCMIPP_VRATIO                  \ [0x10 : 16] Current vertical ratio, from 8192 (1x) to 65535 (8x)
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CDSSZR_DEF
    \
    \ @brief DCMIPP Pipex current downsize destination size register
    \ Address offset: 0xF18
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CCMRICR_DEF
    \
    \ @brief DCMIPP Pipex current common ROI configuration register
    \ Address offset: 0xF20
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_ROILSZ                  \ [0x00 : 2] Current region of interest line size width
    $10 constant DCMIPP_ROI1EN                  \ [0x10] Current region of interest 1 enable
    $11 constant DCMIPP_ROI2EN                  \ [0x11] Current region of interest 2 enable
    $12 constant DCMIPP_ROI3EN                  \ [0x12] Current region of interest 3 enable
    $13 constant DCMIPP_ROI4EN                  \ [0x13] Current region of interest 4 enable
    $14 constant DCMIPP_ROI5EN                  \ [0x14] Current region of interest 5 enable
    $15 constant DCMIPP_ROI6EN                  \ [0x15] Current region of interest 6 enable
    $16 constant DCMIPP_ROI7EN                  \ [0x16] Current region of interest 7 enable
    $17 constant DCMIPP_ROI8EN                  \ [0x17] Current region of interest 8 enable
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI1CR1_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI1 configuration register 1
    \ Address offset: 0xF24
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI1CR2_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI1 configuration register 2
    \ Address offset: 0xF28
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI2CR1_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI2 configuration register 1
    \ Address offset: 0xF2C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI2CR2_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI2 configuration register 2
    \ Address offset: 0xF30
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI3CR1_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI3 configuration register 1
    \ Address offset: 0xF34
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI3CR2_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI3 configuration register 2
    \ Address offset: 0xF38
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI4CR1_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI4 configuration register 1
    \ Address offset: 0xF3C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI4CR2_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI4 configuration register 2
    \ Address offset: 0xF40
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI5CR1_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI5 configuration register 1
    \ Address offset: 0xF44
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI5CR2_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI5 configuration register 2
    \ Address offset: 0xF48
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI6CR1_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI6 configuration register 1
    \ Address offset: 0xF4C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI6CR2_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI6 configuration register 2
    \ Address offset: 0xF50
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI7CR1_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI7 configuration register 1
    \ Address offset: 0xF54
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI7CR2_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI7 configuration register 2
    \ Address offset: 0xF58
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI8CR1_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI8 configuration register 1
    \ Address offset: 0xF5C
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSTART                  \ [0x00 : 12] Current horizontal start, from 0 to 4094 pixels wide
    $0c constant DCMIPP_CLB                     \ [0x0c : 2] Current color line blue
    $0e constant DCMIPP_CLG                     \ [0x0e : 2] Current color line green
    $10 constant DCMIPP_VSTART                  \ [0x10 : 12] Current vertical start, from 0 to 4094 pixels high
    $1c constant DCMIPP_CLR                     \ [0x1c : 2] Current color line red
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CRI8CR2_DEF
    \
    \ @brief DCMIPP Pipe2 current ROI8 configuration register 2
    \ Address offset: 0xF60
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_HSIZE                   \ [0x00 : 12] Current horizontal size, from 0 to 4094 pixels wide
    $10 constant DCMIPP_VSIZE                   \ [0x10 : 12] Current vertical size, from 0 to 4094 pixels high
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CPPCR_DEF
    \
    \ @brief DCMIPP Pipe2 current pixel packer configuration register
    \ Address offset: 0xFC0
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_FORMAT                  \ [0x00 : 4] Memory format (only coplanar formats are supported in Pipe2)
    $04 constant DCMIPP_SWAPRB                  \ [0x04] Swaps R-vs-B components if RGB, and if YUV, swaps U-vs-V components
    $0d constant DCMIPP_LINEMULT                \ [0x0d : 3] Amount of capture completed lines for LINE event and interrupt
    $10 constant DCMIPP_DBM                     \ [0x10] Double buffer mode
    $11 constant DCMIPP_LMAWM                   \ [0x11 : 3] Line multi address wrapping modulo
    $14 constant DCMIPP_LMAWE                   \ [0x14] Line multi address wrapping enable bit
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CPPM0AR1_DEF
    \
    \ @brief DCMIPP Pipe2 current pixel packer Memory0 address register 1
    \ Address offset: 0xFC4
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]


  [ifdef] DCMIPP_DCMIPP_P2CPPM0AR2_DEF
    \
    \ @brief DCMIPP Pipe2 current pixel packer Memory0 address register 2
    \ Address offset: 0xFC8
    \ Reset value: 0x00000000
    \
    $00 constant DCMIPP_M0A                     \ [0x00 : 32] Memory0 address
  [then]

  \
  \ @brief Digital camera interface pixel pipeline
  \
  $00 constant DCMIPP_DCMIPP_IPGR1      \ DCMIPP IPPLUG global register 1
  $04 constant DCMIPP_DCMIPP_IPGR2      \ DCMIPP IPPLUG global register 2
  $08 constant DCMIPP_DCMIPP_IPGR3      \ DCMIPP IPPLUG global register 3
  $1C constant DCMIPP_DCMIPP_IPGR8      \ DCMIPP IPPLUG identification register
  $20 constant DCMIPP_DCMIPP_IPC1R1     \ DCMIPP IPPLUG Clientx register 1
  $24 constant DCMIPP_DCMIPP_IPC1R2     \ DCMIPP IPPLUG Clientx register 2
  $28 constant DCMIPP_DCMIPP_IPC1R3     \ DCMIPP IPPLUG Clientx register 3
  $30 constant DCMIPP_DCMIPP_IPC2R1     \ DCMIPP IPPLUG Clientx register 1
  $34 constant DCMIPP_DCMIPP_IPC2R2     \ DCMIPP IPPLUG Clientx register 2
  $38 constant DCMIPP_DCMIPP_IPC2R3     \ DCMIPP IPPLUG Clientx register 3
  $40 constant DCMIPP_DCMIPP_IPC3R1     \ DCMIPP IPPLUG Clientx register 1
  $44 constant DCMIPP_DCMIPP_IPC3R2     \ DCMIPP IPPLUG Clientx register 2
  $48 constant DCMIPP_DCMIPP_IPC3R3     \ DCMIPP IPPLUG Clientx register 3
  $50 constant DCMIPP_DCMIPP_IPC4R1     \ DCMIPP IPPLUG Clientx register 1
  $54 constant DCMIPP_DCMIPP_IPC4R2     \ DCMIPP IPPLUG Clientx register 2
  $58 constant DCMIPP_DCMIPP_IPC4R3     \ DCMIPP IPPLUG Clientx register 3
  $60 constant DCMIPP_DCMIPP_IPC5R1     \ DCMIPP IPPLUG Clientx register 1
  $64 constant DCMIPP_DCMIPP_IPC5R2     \ DCMIPP IPPLUG Clientx register 2
  $68 constant DCMIPP_DCMIPP_IPC5R3     \ DCMIPP IPPLUG Clientx register 3
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
  $5D0 constant DCMIPP_DCMIPP_P0STM0AR  \ DCMIPP Pipe0 status Memory0 address register
  $5F4 constant DCMIPP_DCMIPP_P0IER     \ DCMIPP Pipe0 interrupt enable register
  $5F8 constant DCMIPP_DCMIPP_P0SR      \ DCMIPP Pipe0 status register
  $5FC constant DCMIPP_DCMIPP_P0FCR     \ DCMIPP Pipe0 interrupt clear register
  $604 constant DCMIPP_DCMIPP_P0CFSCR   \ DCMIPP Pipe0 current flow selection configuration register
  $700 constant DCMIPP_DCMIPP_P0CFCTCR  \ DCMIPP Pipe0 current flow control configuration register
  $704 constant DCMIPP_DCMIPP_P0CSCSTR  \ DCMIPP Pipe0 current stat/crop start register
  $708 constant DCMIPP_DCMIPP_P0CSCSZR  \ DCMIPP Pipe0 current stat/crop size register
  $7C0 constant DCMIPP_DCMIPP_P0CPPCR   \ DCMIPP Pipe0 current pixel packer configuration register
  $7C4 constant DCMIPP_DCMIPP_P0CPPM0AR1    \ DCMIPP Pipe0 current pixel packer Memory0 address register 1
  $7C8 constant DCMIPP_DCMIPP_P0CPPM0AR2    \ DCMIPP Pipe0 current pixel packer Memory0 address register 2
  $804 constant DCMIPP_DCMIPP_P1FSCR    \ DCMIPP Pipe1 flow selection configuration register
  $820 constant DCMIPP_DCMIPP_P1SRCR    \ DCMIPP Pipe1 stat removal configuration register
  $824 constant DCMIPP_DCMIPP_P1BPRCR   \ DCMIPP Pipe1 bad pixel removal control register
  $828 constant DCMIPP_DCMIPP_P1BPRSR   \ DCMIPP Pipe1 bad pixel removal status register
  $830 constant DCMIPP_DCMIPP_P1DECR    \ DCMIPP Pipe1 decimation register
  $840 constant DCMIPP_DCMIPP_P1BLCCR   \ DCMIPP Pipe1 black level calibration control register
  $844 constant DCMIPP_DCMIPP_P1EXCR1   \ DCMIPP Pipe1 exposure control register 1
  $848 constant DCMIPP_DCMIPP_P1EXCR2   \ DCMIPP Pipe1 exposure control register 2
  $850 constant DCMIPP_DCMIPP_P1ST1CR   \ DCMIPP Pipe1 statistics1 control register
  $854 constant DCMIPP_DCMIPP_P1ST2CR   \ DCMIPP Pipe1 statistics 2 control register
  $858 constant DCMIPP_DCMIPP_P1ST3CR   \ DCMIPP Pipe1 statistics 3 control register
  $85C constant DCMIPP_DCMIPP_P1STSTR   \ DCMIPP Pipe1 statistics window start register
  $860 constant DCMIPP_DCMIPP_P1STSZR   \ DCMIPP Pipe1 statistics window size register
  $864 constant DCMIPP_DCMIPP_P1ST1SR   \ DCMIPP Pipe1 statistics 1 status register
  $868 constant DCMIPP_DCMIPP_P1ST2SR   \ DCMIPP Pipe1 statistics 2 status register
  $86C constant DCMIPP_DCMIPP_P1ST3SR   \ DCMIPP Pipe1 statistics 3 status register
  $870 constant DCMIPP_DCMIPP_P1DMCR    \ DCMIPP Pipe1 demosaicing configuration register
  $880 constant DCMIPP_DCMIPP_P1CCCR    \ DCMIPP Pipe1 ColorConv configuration register
  $884 constant DCMIPP_DCMIPP_P1CCRR1   \ DCMIPP Pipe1 ColorConv red coefficient register 1
  $888 constant DCMIPP_DCMIPP_P1CCRR2   \ DCMIPP Pipe1 ColorConv red coefficient register 2
  $88C constant DCMIPP_DCMIPP_P1CCGR1   \ DCMIPP Pipe1 ColorConv green coefficient register 1
  $890 constant DCMIPP_DCMIPP_P1CCGR2   \ DCMIPP Pipe1 ColorConv green coefficient register 2
  $894 constant DCMIPP_DCMIPP_P1CCBR1   \ DCMIPP Pipex ColorConv blue coefficient register 1
  $898 constant DCMIPP_DCMIPP_P1CCBR2   \ DCMIPP Pipe1 ColorConv blue coefficient register 2
  $8A0 constant DCMIPP_DCMIPP_P1CTCR1   \ DCMIPP Pipe1 contrast control register 1
  $8A4 constant DCMIPP_DCMIPP_P1CTCR2   \ DCMIPP Pipe1 contrast control register 2
  $8A8 constant DCMIPP_DCMIPP_P1CTCR3   \ DCMIPP Pipe1 contrast control register 3
  $900 constant DCMIPP_DCMIPP_P1FCTCR   \ DCMIPP Pipex flow control configuration register
  $904 constant DCMIPP_DCMIPP_P1CRSTR   \ DCMIPP Pipex crop window start register
  $908 constant DCMIPP_DCMIPP_P1CRSZR   \ DCMIPP Pipex crop window size register
  $90C constant DCMIPP_DCMIPP_P1DCCR    \ DCMIPP Pipex decimation register
  $910 constant DCMIPP_DCMIPP_P1DSCR    \ DCMIPP Pipex downsize configuration register
  $914 constant DCMIPP_DCMIPP_P1DSRTIOR \ DCMIPP Pipex downsize ratio register
  $918 constant DCMIPP_DCMIPP_P1DSSZR   \ DCMIPP Pipex downsize destination size register
  $920 constant DCMIPP_DCMIPP_P1CMRICR  \ DCMIPP Pipex common ROI configuration register
  $924 constant DCMIPP_DCMIPP_P1RI1CR1  \ DCMIPP Pipe1 ROI1 configuration register 1
  $928 constant DCMIPP_DCMIPP_P1RI1CR2  \ DCMIPP Pipe1 ROI1 configuration register 2
  $92C constant DCMIPP_DCMIPP_P1RI2CR1  \ DCMIPP Pipe1 ROI2 configuration register 1
  $930 constant DCMIPP_DCMIPP_P1RI2CR2  \ DCMIPP Pipe1 ROI2 configuration register 2
  $934 constant DCMIPP_DCMIPP_P1RI3CR1  \ DCMIPP Pipe1 ROI3 configuration register 1
  $938 constant DCMIPP_DCMIPP_P1RI3CR2  \ DCMIPP Pipe1 ROI3 configuration register 2
  $93C constant DCMIPP_DCMIPP_P1RI4CR1  \ DCMIPP Pipe1 ROI4 configuration register 1
  $940 constant DCMIPP_DCMIPP_P1RI4CR2  \ DCMIPP Pipe1 ROI4 configuration register 2
  $944 constant DCMIPP_DCMIPP_P1RI5CR1  \ DCMIPP Pipe1 ROI5 configuration register 1
  $948 constant DCMIPP_DCMIPP_P1RI5CR2  \ DCMIPP Pipe1 ROI5 configuration register 2
  $94C constant DCMIPP_DCMIPP_P1RI6CR1  \ DCMIPP Pipe1 ROI6 configuration register 1
  $950 constant DCMIPP_DCMIPP_P1RI6CR2  \ DCMIPP Pipe1 ROI6 configuration register 2
  $954 constant DCMIPP_DCMIPP_P1RI7CR1  \ DCMIPP Pipe1 ROI7 configuration register 1
  $958 constant DCMIPP_DCMIPP_P1RI7CR2  \ DCMIPP Pipe1 ROI7 configuration register 2
  $95C constant DCMIPP_DCMIPP_P1RI8CR1  \ DCMIPP Pipe1 ROI8 configuration register 1
  $960 constant DCMIPP_DCMIPP_P1RI8CR2  \ DCMIPP Pipe1 ROI8 configuration register 2
  $970 constant DCMIPP_DCMIPP_P1GMCR    \ DCMIPP Pipex gamma configuration register
  $980 constant DCMIPP_DCMIPP_P1YUVCR   \ DCMIPP Pipe1 YUVConv configuration register
  $984 constant DCMIPP_DCMIPP_P1YUVRR1  \ DCMIPP Pipe1 YUVConv red coefficient register 1
  $988 constant DCMIPP_DCMIPP_P1YUVRR2  \ DCMIPP Pipe1 YUVConv red coefficient register 2
  $98C constant DCMIPP_DCMIPP_P1YUVGR1  \ DCMIPP Pipe1 YUVConv green coefficient register 1
  $990 constant DCMIPP_DCMIPP_P1YUVGR2  \ DCMIPP Pipe1 YUVConv green coefficient register 2
  $994 constant DCMIPP_DCMIPP_P1YUVBR1  \ DCMIPP Pipe1 YUVConv blue coefficient register 1
  $998 constant DCMIPP_DCMIPP_P1YUVBR2  \ DCMIPP Pipe1 YUV blue coefficient register 2
  $9C0 constant DCMIPP_DCMIPP_P1PPCR    \ DCMIPP Pipe1 pixel packer configuration register
  $9C4 constant DCMIPP_DCMIPP_P1PPM0AR1 \ DCMIPP Pipe1 pixel packer Memory0 address register 1
  $9C8 constant DCMIPP_DCMIPP_P1PPM0AR2 \ DCMIPP Pipe1 pixel packer Memory0 address register 2
  $9CC constant DCMIPP_DCMIPP_P1PPM0PR  \ DCMIPP Pipex pixel packer Memory0 pitch register
  $9D0 constant DCMIPP_DCMIPP_P1STM0AR  \ DCMIPP Pipex status Memory0 address register
  $9D4 constant DCMIPP_DCMIPP_P1PPM1AR1 \ DCMIPP Pipex pixel packer Memory1 address register 1
  $9D8 constant DCMIPP_DCMIPP_P1PPM1AR2 \ DCMIPP Pipex pixel packer Memory1 address register 2
  $9DC constant DCMIPP_DCMIPP_P1PPM1PR  \ DCMIPP Pipex pixel packer Memory1 pitch register
  $9E0 constant DCMIPP_DCMIPP_P1STM1AR  \ DCMIPP Pipex status Memory1 address register
  $9E4 constant DCMIPP_DCMIPP_P1PPM2AR1 \ DCMIPP Pipex pixel packer memory2 address register 1
  $9E8 constant DCMIPP_DCMIPP_P1PPM2AR2 \ DCMIPP Pipex pixel packer memory2 address register 2
  $9F0 constant DCMIPP_DCMIPP_P1STM2AR  \ DCMIPP Pipex status Memory2 address register
  $9F4 constant DCMIPP_DCMIPP_P1IER     \ DCMIPP Pipe1 interrupt enable register
  $9F8 constant DCMIPP_DCMIPP_P1SR      \ DCMIPP Pipe1 status register
  $9FC constant DCMIPP_DCMIPP_P1FCR     \ DCMIPP Pipe1 interrupt clear register
  $A04 constant DCMIPP_DCMIPP_P1CFSCR   \ DCMIPP Pipe1 current flow selection configuration register
  $A24 constant DCMIPP_DCMIPP_P1CBPRCR  \ DCMIPP Pipe1 current bad pixel removal register
  $A40 constant DCMIPP_DCMIPP_P1CBLCCR  \ DCMIPP Pipe1 current black level calibration control register
  $A44 constant DCMIPP_DCMIPP_P1CEXCR1  \ DCMIPP Pipe1 current exposure control register 1
  $A48 constant DCMIPP_DCMIPP_P1CEXCR2  \ DCMIPP Pipe1 current exposure control register 2
  $A50 constant DCMIPP_DCMIPP_P1CST1CR  \ DCMIPP Pipe1 current statistics 1 control register
  $A54 constant DCMIPP_DCMIPP_P1CST2CR  \ DCMIPP Pipe1 current statistics 2 control register
  $A58 constant DCMIPP_DCMIPP_P1CST3CR  \ DCMIPP Pipe1 current statistics 3 control register
  $A5C constant DCMIPP_DCMIPP_P1CSTSTR  \ DCMIPP Pipe1 current statistics window start register
  $A60 constant DCMIPP_DCMIPP_P1CSTSZR  \ DCMIPP Pipe1 current statistics window size register
  $A80 constant DCMIPP_DCMIPP_P1CCCCR   \ DCMIPP Pipe1 current ColorConv configuration register
  $A84 constant DCMIPP_DCMIPP_P1CCCRR1  \ DCMIPP Pipe1 current ColorConv red coefficient register 1
  $A88 constant DCMIPP_DCMIPP_P1CCCRR2  \ DCMIPP Pipe1 current ColorConv red coefficient register 2
  $A8C constant DCMIPP_DCMIPP_P1CCCGR1  \ DCMIPP Pipe1 current ColorConv green coefficient register 1
  $A90 constant DCMIPP_DCMIPP_P1CCCGR2  \ DCMIPP Pipe1 current ColorConv green coefficient register 2
  $A94 constant DCMIPP_DCMIPP_P1CCCBR1  \ DCMIPP Pipex current ColorConv blue coefficient register 1
  $A98 constant DCMIPP_DCMIPP_P1CCCBR2  \ DCMIPP Pipe1 current ColorConv blue coefficient register 2
  $AA0 constant DCMIPP_DCMIPP_P1CCTCR1  \ DCMIPP Pipe1 current contrast control register 1
  $AA4 constant DCMIPP_DCMIPP_P1CCTCR2  \ DCMIPP Pipe1 current contrast control register 2
  $AA8 constant DCMIPP_DCMIPP_P1CCTCR3  \ DCMIPP Pipe1 current contrast control register 3
  $B00 constant DCMIPP_DCMIPP_P1CFCTCR  \ DCMIPP Pipex current flow control configuration register
  $B04 constant DCMIPP_DCMIPP_P1CCRSTR  \ DCMIPP Pipex current crop window start register
  $B08 constant DCMIPP_DCMIPP_P1CCRSZR  \ DCMIPP Pipex current crop window size register
  $B0C constant DCMIPP_DCMIPP_P1CDCCR   \ DCMIPP Pipex current decimation register
  $B10 constant DCMIPP_DCMIPP_P1CDSCR   \ DCMIPP Pipex current downsize configuration register
  $B14 constant DCMIPP_DCMIPP_P1CDSRTIOR    \ DCMIPP Pipex current downsize ratio register
  $B18 constant DCMIPP_DCMIPP_P1CDSSZR  \ DCMIPP Pipex current downsize destination size register
  $B20 constant DCMIPP_DCMIPP_P1CCMRICR \ DCMIPP Pipex current common ROI configuration register
  $B24 constant DCMIPP_DCMIPP_P1CRI1CR1 \ DCMIPP Pipe1 current ROI1 configuration register 1
  $B28 constant DCMIPP_DCMIPP_P1CRI1CR2 \ DCMIPP Pipe1 current ROI1 configuration register 2
  $B2C constant DCMIPP_DCMIPP_P1CRI2CR1 \ DCMIPP Pipe1 current ROI2 configuration register 1
  $B30 constant DCMIPP_DCMIPP_P1CRI2CR2 \ DCMIPP Pipe1 current ROI2 configuration register 2
  $B34 constant DCMIPP_DCMIPP_P1CRI3CR1 \ DCMIPP Pipe1 current ROI3 configuration register 1
  $B38 constant DCMIPP_DCMIPP_P1CRI3CR2 \ DCMIPP Pipe1 current ROI3 configuration register 2
  $B3C constant DCMIPP_DCMIPP_P1CRI4CR1 \ DCMIPP Pipe1 current ROI4 configuration register 1
  $B40 constant DCMIPP_DCMIPP_P1CRI4CR2 \ DCMIPP Pipe1 current ROI4 configuration register 2
  $B44 constant DCMIPP_DCMIPP_P1CRI5CR1 \ DCMIPP Pipe1 current ROI5 configuration register 1
  $B48 constant DCMIPP_DCMIPP_P1CRI5CR2 \ DCMIPP Pipe1 current ROI5 configuration register 2
  $B4C constant DCMIPP_DCMIPP_P1CRI6CR1 \ DCMIPP Pipe1 current ROI6 configuration register 1
  $B50 constant DCMIPP_DCMIPP_P1CRI6CR2 \ DCMIPP Pipe1 current ROI6 configuration register 2
  $B54 constant DCMIPP_DCMIPP_P1CRI7CR1 \ DCMIPP Pipe1 current ROI7 configuration register 1
  $B58 constant DCMIPP_DCMIPP_P1CRI7CR2 \ DCMIPP Pipe1 current ROI7 configuration register 2
  $B5C constant DCMIPP_DCMIPP_P1CRI8CR1 \ DCMIPP Pipe1 current ROI8 configuration register 1
  $B60 constant DCMIPP_DCMIPP_P1CRI8CR2 \ DCMIPP Pipe1 current ROI8 configuration register 2
  $BC0 constant DCMIPP_DCMIPP_P1CPPCR   \ DCMIPP Pipe1 current pixel packer configuration register
  $BC4 constant DCMIPP_DCMIPP_P1CPPM0AR1    \ DCMIPP Pipe1 current pixel packer Memory0 address register 1
  $BC8 constant DCMIPP_DCMIPP_P1CPPM0AR2    \ DCMIPP Pipe1 current pixel packer Memory0 address register 2
  $BCC constant DCMIPP_DCMIPP_P1CPPM0PR \ DCMIPP Pipex current pixel packer Memory0 pitch register
  $BD4 constant DCMIPP_DCMIPP_P1CPPM1AR1    \ DCMIPP Pipex current pixel packer Memory1 address register 1
  $BD8 constant DCMIPP_DCMIPP_P1CPPM1AR2    \ DCMIPP Pipex current pixel packer Memory1 address register 2
  $BDC constant DCMIPP_DCMIPP_P1CPPM1PR \ DCMIPP Pipex current pixel packer Memory1 pitch register
  $BE4 constant DCMIPP_DCMIPP_P1CPPM2AR1    \ DCMIPP Pipex current pixel packer Memory2 address register 1
  $BE8 constant DCMIPP_DCMIPP_P1CPPM2AR2    \ DCMIPP Pipex current pixel packer Memory2 address register 1
  $C04 constant DCMIPP_DCMIPP_P2FSCR    \ DCMIPP Pipe2 flow selection configuration register
  $D00 constant DCMIPP_DCMIPP_P2FCTCR   \ DCMIPP Pipex flow control configuration register
  $D04 constant DCMIPP_DCMIPP_P2CRSTR   \ DCMIPP Pipex crop window start register
  $D08 constant DCMIPP_DCMIPP_P2CRSZR   \ DCMIPP Pipex crop window size register
  $D0C constant DCMIPP_DCMIPP_P2DCCR    \ DCMIPP Pipex decimation register
  $D10 constant DCMIPP_DCMIPP_P2DSCR    \ DCMIPP Pipex downsize configuration register
  $D14 constant DCMIPP_DCMIPP_P2DSRTIOR \ DCMIPP Pipex downsize ratio register
  $D18 constant DCMIPP_DCMIPP_P2DSSZR   \ DCMIPP Pipex downsize destination size register
  $D20 constant DCMIPP_DCMIPP_P2CMRICR  \ DCMIPP Pipex common ROI configuration register
  $D24 constant DCMIPP_DCMIPP_P2RI1CR1  \ DCMIPP Pipe2 ROI1 configuration register 1
  $D28 constant DCMIPP_DCMIPP_P2RI1CR2  \ DCMIPP Pipe2 ROI1 configuration register 2
  $D2C constant DCMIPP_DCMIPP_P2RI2CR1  \ DCMIPP Pipe2 ROI2 configuration register 1
  $D30 constant DCMIPP_DCMIPP_P2RI2CR2  \ DCMIPP Pipe2 ROI2 configuration register 2
  $D34 constant DCMIPP_DCMIPP_P2RI3CR1  \ DCMIPP Pipe2 ROI3 configuration register 1
  $D38 constant DCMIPP_DCMIPP_P2RI3CR2  \ DCMIPP Pipe2 ROI3 configuration register 2
  $D3C constant DCMIPP_DCMIPP_P2RI4CR1  \ DCMIPP Pipe2 ROI4 configuration register 1
  $D40 constant DCMIPP_DCMIPP_P2RI4CR2  \ DCMIPP Pipe2 ROI4 configuration register 2
  $D44 constant DCMIPP_DCMIPP_P2RI5CR1  \ DCMIPP Pipe2 ROI5 configuration register 1
  $D48 constant DCMIPP_DCMIPP_P2RI5CR2  \ DCMIPP Pipe2 ROI5 configuration register 2
  $D4C constant DCMIPP_DCMIPP_P2RI6CR1  \ DCMIPP Pipe2 ROI6 configuration register 1
  $D50 constant DCMIPP_DCMIPP_P2RI6CR2  \ DCMIPP Pipe2 ROI6 configuration register 2
  $D54 constant DCMIPP_DCMIPP_P2RI7CR1  \ DCMIPP Pipe2 ROI7 configuration register 1
  $D58 constant DCMIPP_DCMIPP_P2RI7CR2  \ DCMIPP Pipe2 ROI7 configuration register 2
  $D5C constant DCMIPP_DCMIPP_P2RI8CR1  \ DCMIPP Pipe2 ROI8 configuration register 1
  $D60 constant DCMIPP_DCMIPP_P2RI8CR2  \ DCMIPP Pipe2 ROI8 configuration register 2
  $D70 constant DCMIPP_DCMIPP_P2GMCR    \ DCMIPP Pipex gamma configuration register
  $DC0 constant DCMIPP_DCMIPP_P2PPCR    \ DCMIPP Pipe2 pixel packer configuration register
  $DC4 constant DCMIPP_DCMIPP_P2PPM0AR1 \ DCMIPP Pipe2 pixel packer Memory0 address register 1
  $DC8 constant DCMIPP_DCMIPP_P2PPM0AR2 \ DCMIPP Pipe2 pixel packer Memory0 address register 2
  $DCC constant DCMIPP_DCMIPP_P2PPM0PR  \ DCMIPP Pipex pixel packer Memory0 pitch register
  $DD0 constant DCMIPP_DCMIPP_P2STM0AR  \ DCMIPP Pipex status Memory0 address register
  $DF4 constant DCMIPP_DCMIPP_P2IER     \ DCMIPP Pipe2 interrupt enable register
  $DF8 constant DCMIPP_DCMIPP_P2SR      \ DCMIPP Pipe2 status register
  $DFC constant DCMIPP_DCMIPP_P2FCR     \ DCMIPP Pipe2 interrupt clear register
  $E04 constant DCMIPP_DCMIPP_P2CFSCR   \ DCMIPP Pipe2 current flow selection configuration register
  $F00 constant DCMIPP_DCMIPP_P2CFCTCR  \ DCMIPP Pipex current flow control configuration register
  $F04 constant DCMIPP_DCMIPP_P2CCRSTR  \ DCMIPP Pipex current crop window start register
  $F08 constant DCMIPP_DCMIPP_P2CCRSZR  \ DCMIPP Pipex current crop window size register
  $F0C constant DCMIPP_DCMIPP_P2CDCCR   \ DCMIPP Pipex current decimation register
  $F10 constant DCMIPP_DCMIPP_P2CDSCR   \ DCMIPP Pipex current downsize configuration register
  $F14 constant DCMIPP_DCMIPP_P2CDSRTIOR    \ DCMIPP Pipex current downsize ratio register
  $F18 constant DCMIPP_DCMIPP_P2CDSSZR  \ DCMIPP Pipex current downsize destination size register
  $F20 constant DCMIPP_DCMIPP_P2CCMRICR \ DCMIPP Pipex current common ROI configuration register
  $F24 constant DCMIPP_DCMIPP_P2CRI1CR1 \ DCMIPP Pipe2 current ROI1 configuration register 1
  $F28 constant DCMIPP_DCMIPP_P2CRI1CR2 \ DCMIPP Pipe2 current ROI1 configuration register 2
  $F2C constant DCMIPP_DCMIPP_P2CRI2CR1 \ DCMIPP Pipe2 current ROI2 configuration register 1
  $F30 constant DCMIPP_DCMIPP_P2CRI2CR2 \ DCMIPP Pipe2 current ROI2 configuration register 2
  $F34 constant DCMIPP_DCMIPP_P2CRI3CR1 \ DCMIPP Pipe2 current ROI3 configuration register 1
  $F38 constant DCMIPP_DCMIPP_P2CRI3CR2 \ DCMIPP Pipe2 current ROI3 configuration register 2
  $F3C constant DCMIPP_DCMIPP_P2CRI4CR1 \ DCMIPP Pipe2 current ROI4 configuration register 1
  $F40 constant DCMIPP_DCMIPP_P2CRI4CR2 \ DCMIPP Pipe2 current ROI4 configuration register 2
  $F44 constant DCMIPP_DCMIPP_P2CRI5CR1 \ DCMIPP Pipe2 current ROI5 configuration register 1
  $F48 constant DCMIPP_DCMIPP_P2CRI5CR2 \ DCMIPP Pipe2 current ROI5 configuration register 2
  $F4C constant DCMIPP_DCMIPP_P2CRI6CR1 \ DCMIPP Pipe2 current ROI6 configuration register 1
  $F50 constant DCMIPP_DCMIPP_P2CRI6CR2 \ DCMIPP Pipe2 current ROI6 configuration register 2
  $F54 constant DCMIPP_DCMIPP_P2CRI7CR1 \ DCMIPP Pipe2 current ROI7 configuration register 1
  $F58 constant DCMIPP_DCMIPP_P2CRI7CR2 \ DCMIPP Pipe2 current ROI7 configuration register 2
  $F5C constant DCMIPP_DCMIPP_P2CRI8CR1 \ DCMIPP Pipe2 current ROI8 configuration register 1
  $F60 constant DCMIPP_DCMIPP_P2CRI8CR2 \ DCMIPP Pipe2 current ROI8 configuration register 2
  $FC0 constant DCMIPP_DCMIPP_P2CPPCR   \ DCMIPP Pipe2 current pixel packer configuration register
  $FC4 constant DCMIPP_DCMIPP_P2CPPM0AR1    \ DCMIPP Pipe2 current pixel packer Memory0 address register 1
  $FC8 constant DCMIPP_DCMIPP_P2CPPM0AR2    \ DCMIPP Pipe2 current pixel packer Memory0 address register 2

: DCMIPP_DEF ; [then]
