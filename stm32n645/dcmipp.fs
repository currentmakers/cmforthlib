\
\ @file dcmipp.fs
\ @brief Digital camera interface pixel pipeline
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DCMIPP IPPLUG global register 1
\ Address offset: 0x00
\ Reset value: 0x00000002
\

$00000007 constant DCMIPP_DCMIPP_IPGR1_MEMORYPAGE                   \ Memory page size, as power of 2 of 64-byte units:
$01000000 constant DCMIPP_DCMIPP_IPGR1_QOS_MODE                     \ Quality of service


\
\ @brief DCMIPP IPPLUG global register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_IPGR2_PSTART                       \ Request to lock the IP-Plug, to allow reconfiguration.


\
\ @brief DCMIPP IPPLUG global register 3
\ Address offset: 0x08
\ Reset value: 0x00000001
\

$00000001 constant DCMIPP_DCMIPP_IPGR3_IDLE                         \ Status of IP-Plug


\
\ @brief DCMIPP IPPLUG identification register
\ Address offset: 0x1C
\ Reset value: 0xAA040314
\

$0000003f constant DCMIPP_DCMIPP_IPGR8_DID                          \ Division identifier (0x14)
$00001f00 constant DCMIPP_DCMIPP_IPGR8_REVID                        \ Revision identifier (0x03)
$001f0000 constant DCMIPP_DCMIPP_IPGR8_ARCHIID                      \ Architecture identifier (0x04)
$ff000000 constant DCMIPP_DCMIPP_IPGR8_IPPID                        \ IP identifier (0xAA)


\
\ @brief DCMIPP IPPLUG Clientx register 1
\ Address offset: 0x20
\ Reset value: 0x00000004
\

$00000007 constant DCMIPP_DCMIPP_IPC1R1_TRAFFIC                     \ Burst size as power of 2 of 8-byte units
$00000f00 constant DCMIPP_DCMIPP_IPC1R1_OTR                         \ Maximum outstanding transactions


\
\ @brief DCMIPP IPPLUG Clientx register 2
\ Address offset: 0x24
\ Reset value: 0x00010000
\

$00000f00 constant DCMIPP_DCMIPP_IPC1R2_SVCMAPPING                  \ Non-user, must be kept at reset value.
$000f0000 constant DCMIPP_DCMIPP_IPC1R2_WLRU                        \ Ratio for WLRU[3:0] arbitration


\
\ @brief DCMIPP IPPLUG Clientx register 3
\ Address offset: 0x28
\ Reset value: 0x007F0000
\

$000003ff constant DCMIPP_DCMIPP_IPC1R3_DPREGSTART                  \ Start word (AXI width = 64 bits) of the FIFO of Clientx.
$03ff0000 constant DCMIPP_DCMIPP_IPC1R3_DPREGEND                    \ End word (AXI width = 64 bits) of the FIFO of Clientx.


\
\ @brief DCMIPP IPPLUG Clientx register 1
\ Address offset: 0x30
\ Reset value: 0x00000004
\

$00000007 constant DCMIPP_DCMIPP_IPC2R1_TRAFFIC                     \ Burst size as power of 2 of 8-byte units
$00000f00 constant DCMIPP_DCMIPP_IPC2R1_OTR                         \ Maximum outstanding transactions


\
\ @brief DCMIPP IPPLUG Clientx register 2
\ Address offset: 0x34
\ Reset value: 0x00010000
\

$00000f00 constant DCMIPP_DCMIPP_IPC2R2_SVCMAPPING                  \ Non-user, must be kept at reset value.
$000f0000 constant DCMIPP_DCMIPP_IPC2R2_WLRU                        \ Ratio for WLRU[3:0] arbitration


\
\ @brief DCMIPP IPPLUG Clientx register 3
\ Address offset: 0x38
\ Reset value: 0x013F0080
\

$000003ff constant DCMIPP_DCMIPP_IPC2R3_DPREGSTART                  \ Start word (AXI width = 64 bits) of the FIFO of Clientx.
$03ff0000 constant DCMIPP_DCMIPP_IPC2R3_DPREGEND                    \ End word (AXI width = 64 bits) of the FIFO of Clientx.


\
\ @brief DCMIPP IPPLUG Clientx register 1
\ Address offset: 0x40
\ Reset value: 0x00000004
\

$00000007 constant DCMIPP_DCMIPP_IPC3R1_TRAFFIC                     \ Burst size as power of 2 of 8-byte units
$00000f00 constant DCMIPP_DCMIPP_IPC3R1_OTR                         \ Maximum outstanding transactions


\
\ @brief DCMIPP IPPLUG Clientx register 2
\ Address offset: 0x44
\ Reset value: 0x00010000
\

$00000f00 constant DCMIPP_DCMIPP_IPC3R2_SVCMAPPING                  \ Non-user, must be kept at reset value.
$000f0000 constant DCMIPP_DCMIPP_IPC3R2_WLRU                        \ Ratio for WLRU[3:0] arbitration


\
\ @brief DCMIPP IPPLUG Clientx register 3
\ Address offset: 0x48
\ Reset value: 0x018F0140
\

$000003ff constant DCMIPP_DCMIPP_IPC3R3_DPREGSTART                  \ Start word (AXI width = 64 bits) of the FIFO of Clientx.
$03ff0000 constant DCMIPP_DCMIPP_IPC3R3_DPREGEND                    \ End word (AXI width = 64 bits) of the FIFO of Clientx.


\
\ @brief DCMIPP IPPLUG Clientx register 1
\ Address offset: 0x50
\ Reset value: 0x00000004
\

$00000007 constant DCMIPP_DCMIPP_IPC4R1_TRAFFIC                     \ Burst size as power of 2 of 8-byte units
$00000f00 constant DCMIPP_DCMIPP_IPC4R1_OTR                         \ Maximum outstanding transactions


\
\ @brief DCMIPP IPPLUG Clientx register 2
\ Address offset: 0x54
\ Reset value: 0x00010000
\

$00000f00 constant DCMIPP_DCMIPP_IPC4R2_SVCMAPPING                  \ Non-user, must be kept at reset value.
$000f0000 constant DCMIPP_DCMIPP_IPC4R2_WLRU                        \ Ratio for WLRU[3:0] arbitration


\
\ @brief DCMIPP IPPLUG Clientx register 3
\ Address offset: 0x58
\ Reset value: 0x01BF0190
\

$000003ff constant DCMIPP_DCMIPP_IPC4R3_DPREGSTART                  \ Start word (AXI width = 64 bits) of the FIFO of Clientx.
$03ff0000 constant DCMIPP_DCMIPP_IPC4R3_DPREGEND                    \ End word (AXI width = 64 bits) of the FIFO of Clientx.


\
\ @brief DCMIPP IPPLUG Clientx register 1
\ Address offset: 0x60
\ Reset value: 0x00000004
\

$00000007 constant DCMIPP_DCMIPP_IPC5R1_TRAFFIC                     \ Burst size as power of 2 of 8-byte units
$00000f00 constant DCMIPP_DCMIPP_IPC5R1_OTR                         \ Maximum outstanding transactions


\
\ @brief DCMIPP IPPLUG Clientx register 2
\ Address offset: 0x64
\ Reset value: 0x00010000
\

$00000f00 constant DCMIPP_DCMIPP_IPC5R2_SVCMAPPING                  \ Non-user, must be kept at reset value.
$000f0000 constant DCMIPP_DCMIPP_IPC5R2_WLRU                        \ Ratio for WLRU[3:0] arbitration


\
\ @brief DCMIPP IPPLUG Clientx register 3
\ Address offset: 0x68
\ Reset value: 0x027F01C0
\

$000003ff constant DCMIPP_DCMIPP_IPC5R3_DPREGSTART                  \ Start word (AXI width = 64 bits) of the FIFO of Clientx.
$03ff0000 constant DCMIPP_DCMIPP_IPC5R3_DPREGEND                    \ End word (AXI width = 64 bits) of the FIFO of Clientx.


\
\ @brief DCMIPP parallel interface control register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000010 constant DCMIPP_DCMIPP_PRCR_ESS                           \ Embedded synchronization select
$00000020 constant DCMIPP_DCMIPP_PRCR_PCKPOL                        \ Pixel clock polarity
$00000040 constant DCMIPP_DCMIPP_PRCR_HSPOL                         \ Horizontal synchronization polarity
$00000080 constant DCMIPP_DCMIPP_PRCR_VSPOL                         \ Vertical synchronization polarity
$00001c00 constant DCMIPP_DCMIPP_PRCR_EDM                           \ Extended data mode
$00004000 constant DCMIPP_DCMIPP_PRCR_ENABLE                        \ Parallel interface enable
$00ff0000 constant DCMIPP_DCMIPP_PRCR_FORMAT                        \ Other values: data are captured and output as-is only through the data/dump pipeline (e.g. JPEG or byte input format).
$02000000 constant DCMIPP_DCMIPP_PRCR_SWAPCYCLES                    \ Swap data (cycle 0 vs. cycle 1) for pixels received on two cycles
$04000000 constant DCMIPP_DCMIPP_PRCR_SWAPBITS                      \ Swap LSB vs. MSB within each received component


\
\ @brief DCMIPP parallel interface embedded synchronization code register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$000000ff constant DCMIPP_DCMIPP_PRESCR_FSC                         \ Frame start delimiter code
$0000ff00 constant DCMIPP_DCMIPP_PRESCR_LSC                         \ Line start delimiter code
$00ff0000 constant DCMIPP_DCMIPP_PRESCR_LEC                         \ Line end delimiter code
$ff000000 constant DCMIPP_DCMIPP_PRESCR_FEC                         \ Frame end delimiter code


\
\ @brief DCMIPP parallel interface embedded synchronization unmask register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$000000ff constant DCMIPP_DCMIPP_PRESUR_FSU                         \ Frame start delimiter unmask
$0000ff00 constant DCMIPP_DCMIPP_PRESUR_LSU                         \ Line start delimiter unmask
$00ff0000 constant DCMIPP_DCMIPP_PRESUR_LEU                         \ Line end delimiter unmask
$ff000000 constant DCMIPP_DCMIPP_PRESUR_FEU                         \ Frame end delimiter unmask


\
\ @brief DCMIPP parallel interface interrupt enable register
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$00000040 constant DCMIPP_DCMIPP_PRIER_ERRIE                        \ Synchronization error interrupt enable


\
\ @brief DCMIPP parallel interface status register
\ Address offset: 0x1F8
\ Reset value: 0x00030000
\

$00000040 constant DCMIPP_DCMIPP_PRSR_ERRF                          \ Synchronization error raw interrupt status
$00010000 constant DCMIPP_DCMIPP_PRSR_HSYNC                         \ This bit gives the state of the HSYNC pin with the correct programmed polarity if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in HPOL bit, and cleared otherwise.
$00020000 constant DCMIPP_DCMIPP_PRSR_VSYNC                         \ This bit gives the state of the VSYNC pin with the correct programmed polarity if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in VPOL bit, and cleared otherwise.


\
\ @brief DCMIPP parallel interface interrupt clear register
\ Address offset: 0x1FC
\ Reset value: 0x00000000
\

$00000040 constant DCMIPP_DCMIPP_PRFCR_CERRF                        \ Synchronization error interrupt status clear


\
\ @brief DCMIPP common configuration register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_CMCR_INSEL                         \ input selection
$00000006 constant DCMIPP_DCMIPP_CMCR_PSFC                          \ Pipe selection for the frame counter
$00000010 constant DCMIPP_DCMIPP_CMCR_CFC                           \ Clear frame counter
$00000080 constant DCMIPP_DCMIPP_CMCR_SWAPRB                        \ Swap R/U and B/V


\
\ @brief DCMIPP common frame counter register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_CMFRCR_FRMCNT                      \ Frame counter, read-only, loops around.


\
\ @brief DCMIPP common interrupt enable register
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$00000020 constant DCMIPP_DCMIPP_CMIER_ATXERRIE                     \ AXI transfer error interrupt enable for IPPLUG
$00000040 constant DCMIPP_DCMIPP_CMIER_PRERRIE                      \ Limit interrupt enable for the parallel Interface
$00000100 constant DCMIPP_DCMIPP_CMIER_P0LINEIE                     \ Multi-line capture complete interrupt enable for Pipe0
$00000200 constant DCMIPP_DCMIPP_CMIER_P0FRAMEIE                    \ Frame capture complete interrupt enable for Pipe0
$00000400 constant DCMIPP_DCMIPP_CMIER_P0VSYNCIE                    \ Vertical sync interrupt enable for Pipe0
$00004000 constant DCMIPP_DCMIPP_CMIER_P0LIMITIE                    \ Limit interrupt enable for Pipe0
$00008000 constant DCMIPP_DCMIPP_CMIER_P0OVRIE                      \ Overrun interrupt enable for Pipe0
$00010000 constant DCMIPP_DCMIPP_CMIER_P1LINEIE                     \ Multi-line capture complete interrupt status clear for Pipe1
$00020000 constant DCMIPP_DCMIPP_CMIER_P1FRAMEIE                    \ Frame capture complete interrupt enable for Pipe1
$00040000 constant DCMIPP_DCMIPP_CMIER_P1VSYNCIE                    \ Vertical sync interrupt enable for Pipe1
$00800000 constant DCMIPP_DCMIPP_CMIER_P1OVRIE                      \ Overrun interrupt enable for Pipe1
$01000000 constant DCMIPP_DCMIPP_CMIER_P2LINEIE                     \ Multi-line capture complete interrupt enable for Pipe2
$02000000 constant DCMIPP_DCMIPP_CMIER_P2FRAMEIE                    \ Frame capture complete interrupt enable for Pipe2
$04000000 constant DCMIPP_DCMIPP_CMIER_P2VSYNCIE                    \ Vertical sync interrupt enable for Pipe2
$80000000 constant DCMIPP_DCMIPP_CMIER_P2OVRIE                      \ Overrun interrupt status enable for Pipe2


\
\ @brief DCMIPP common status register 1
\ Address offset: 0x3F4
\ Reset value: 0x00000003
\

$00000001 constant DCMIPP_DCMIPP_CMSR1_PRHSYNC                      \ This bit gives the state of the HSYNC pin with the correct programmed polarity on the parallel interface if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in HPOL bit of the DCMIPP_PRCR register, and cleared otherwise.
$00000002 constant DCMIPP_DCMIPP_CMSR1_PRVSYNC                      \ This bit gives the state of the VSYNC pin with the correct programmed polarity on the parallel interface if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in VPOL bit of the DCMIPP_PRCR register, and cleared otherwise.
$00000100 constant DCMIPP_DCMIPP_CMSR1_P0LSTLINE                    \ Last line LSB bit, sampled at Frame capture complete event for Pipe0
$00000200 constant DCMIPP_DCMIPP_CMSR1_P0LSTFRM                     \ Last frame LSB bit, sampled at Frame capture complete event for Pipe0
$00008000 constant DCMIPP_DCMIPP_CMSR1_P0CPTACT                     \ Active frame capture (active from start-of-frame to frame complete) for Pipe0
$00010000 constant DCMIPP_DCMIPP_CMSR1_P1LSTLINE                    \ Last line LSB bit, sampled at Frame capture complete event for Pipe1
$00020000 constant DCMIPP_DCMIPP_CMSR1_P1LSTFRM                     \ Last frame LSB bit, sampled at frame capture complete event for Pipe1
$00800000 constant DCMIPP_DCMIPP_CMSR1_P1CPTACT                     \ Active frame capture (active from start-of-frame to frame complete) for Pipe1
$01000000 constant DCMIPP_DCMIPP_CMSR1_P2LSTLINE                    \ Last line LSB bit, sampled at frame capture complete event for Pipe2
$02000000 constant DCMIPP_DCMIPP_CMSR1_P2LSTFRM                     \ Last frame LSB bit, sampled at frame capture complete event for Pipe2
$80000000 constant DCMIPP_DCMIPP_CMSR1_P2CPTACT                     \ Active frame capture (active from start-of-frame to frame complete) for Pipe2


\
\ @brief DCMIPP common status register 2
\ Address offset: 0x3F8
\ Reset value: 0x00000000
\

$00000020 constant DCMIPP_DCMIPP_CMSR2_ATXERRF                      \ AXI transfer error interrupt status flag for the IPPLUG.
$00000040 constant DCMIPP_DCMIPP_CMSR2_PRERRF                       \ Synchronization error raw interrupt status for the parallel interface.
$00000100 constant DCMIPP_DCMIPP_CMSR2_P0LINEF                      \ Multi-line capture completed raw interrupt status for Pipe0
$00000200 constant DCMIPP_DCMIPP_CMSR2_P0FRAMEF                     \ Frame capture completed raw interrupt status for Pipe0
$00000400 constant DCMIPP_DCMIPP_CMSR2_P0VSYNCF                     \ VSYNC raw interrupt status for Pipe0
$00004000 constant DCMIPP_DCMIPP_CMSR2_P0LIMITF                     \ Limit raw interrupt status for Pipe0
$00008000 constant DCMIPP_DCMIPP_CMSR2_P0OVRF                       \ Overrun raw interrupt status for Pipe0
$00010000 constant DCMIPP_DCMIPP_CMSR2_P1LINEF                      \ Multi-line capture completed raw interrupt status for Pipe1
$00020000 constant DCMIPP_DCMIPP_CMSR2_P1FRAMEF                     \ Frame capture completed raw interrupt status for Pipe1
$00040000 constant DCMIPP_DCMIPP_CMSR2_P1VSYNCF                     \ VSYNC raw interrupt status for Pipe1
$00800000 constant DCMIPP_DCMIPP_CMSR2_P1OVRF                       \ Overrun raw interrupt status for Pipe1
$01000000 constant DCMIPP_DCMIPP_CMSR2_P2LINEF                      \ Multi-line capture completed raw interrupt status for Pipe2
$02000000 constant DCMIPP_DCMIPP_CMSR2_P2FRAMEF                     \ Frame capture completed raw interrupt status for Pipe2
$04000000 constant DCMIPP_DCMIPP_CMSR2_P2VSYNCF                     \ VSYNC raw interrupt status for Pipe2
$80000000 constant DCMIPP_DCMIPP_CMSR2_P2OVRF                       \ Overrun raw interrupt status for Pipe2


\
\ @brief DCMIPP common interrupt clear register
\ Address offset: 0x3FC
\ Reset value: 0x00000000
\

$00000020 constant DCMIPP_DCMIPP_CMFCR_CATXERRF                     \ AXI transfer error interrupt status clear
$00000040 constant DCMIPP_DCMIPP_CMFCR_CPRERRF                      \ Synchronization error interrupt status clear
$00000100 constant DCMIPP_DCMIPP_CMFCR_CP0LINEF                     \ Multi-line capture complete interrupt status clear
$00000200 constant DCMIPP_DCMIPP_CMFCR_CP0FRAMEF                    \ Frame capture complete interrupt status clear
$00000400 constant DCMIPP_DCMIPP_CMFCR_CP0VSYNCF                    \ Vertical synchronization interrupt status clear
$00004000 constant DCMIPP_DCMIPP_CMFCR_CP0LIMITF                    \ limit interrupt status clear
$00008000 constant DCMIPP_DCMIPP_CMFCR_CP0OVRF                      \ Overrun interrupt status clear
$00010000 constant DCMIPP_DCMIPP_CMFCR_CP1LINEF                     \ Multi-line capture complete interrupt status clear
$00020000 constant DCMIPP_DCMIPP_CMFCR_CP1FRAMEF                    \ Frame capture complete interrupt status clear
$00040000 constant DCMIPP_DCMIPP_CMFCR_CP1VSYNCF                    \ Vertical synchronization interrupt status clear
$00800000 constant DCMIPP_DCMIPP_CMFCR_CP1OVRF                      \ Overrun interrupt status clear
$01000000 constant DCMIPP_DCMIPP_CMFCR_CP2LINEF                     \ Multi-line capture complete interrupt status clear
$02000000 constant DCMIPP_DCMIPP_CMFCR_CP2FRAMEF                    \ Frame capture complete interrupt status clear
$04000000 constant DCMIPP_DCMIPP_CMFCR_CP2VSYNCF                    \ Vertical synchronization interrupt status clear
$80000000 constant DCMIPP_DCMIPP_CMFCR_CP2OVRF                      \ Overrun interrupt status clear


\
\ @brief DCMIPP Pipe0 flow selection configuration register
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$0000003f constant DCMIPP_DCMIPP_P0FSCR_DTIDA                       \ Data type selection ID A
$00003f00 constant DCMIPP_DCMIPP_P0FSCR_DTIDB                       \ Data type selection ID B
$00030000 constant DCMIPP_DCMIPP_P0FSCR_DTMODE                      \ Flow selection mode
$00180000 constant DCMIPP_DCMIPP_P0FSCR_VC                          \ Flow selection mode
$80000000 constant DCMIPP_DCMIPP_P0FSCR_PIPEN                       \ Activation of PipeN


\
\ @brief DCMIPP Pipe0 flow control configuration register
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P0FCTCR_FRATE                      \ Frame capture rate control
$00000004 constant DCMIPP_DCMIPP_P0FCTCR_CPTMODE                    \ Capture mode
$00000008 constant DCMIPP_DCMIPP_P0FCTCR_CPTREQ                     \ Capture requested


\
\ @brief DCMIPP Pipe0 stat/crop start register
\ Address offset: 0x504
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P0SCSTR_HSTART                     \ Horizontal start, from 0 to 4094 words wide
$0fff0000 constant DCMIPP_DCMIPP_P0SCSTR_VSTART                     \ Vertical start, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe0 stat/crop size register
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P0SCSZR_HSIZE                      \ Horizontal size, from 0 to 4094 word wide (data 32-bit)
$0fff0000 constant DCMIPP_DCMIPP_P0SCSZR_VSIZE                      \ Vertical size, from 0 to 4094 pixels high
$40000000 constant DCMIPP_DCMIPP_P0SCSZR_POSNEG                     \ This bit is set and cleared by software. It has a meaning only if ENABLE bit is set.
$80000000 constant DCMIPP_DCMIPP_P0SCSZR_ENABLE                     \ This bit is set and cleared by software.


\
\ @brief DCMIPP Pipe0 dump counter register
\ Address offset: 0x5B0
\ Reset value: 0x00000000
\

$03ffffff constant DCMIPP_DCMIPP_P0DCCNTR_CNT                       \ Number of data dumped during the frame.


\
\ @brief DCMIPP Pipe0 dump limit register
\ Address offset: 0x5B4
\ Reset value: 0x00FFFFFF
\

$00ffffff constant DCMIPP_DCMIPP_P0DCLMTR_LIMIT                     \ Maximum number of 32-bit data that can be dumped during a frame, after the crop 2D operation.
$80000000 constant DCMIPP_DCMIPP_P0DCLMTR_ENABLE                    \ None


\
\ @brief DCMIPP Pipe0 pixel packer configuration register
\ Address offset: 0x5C0
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P0PPCR_SWAPYUV                     \ Swaps, within a 32-bit word, byte 0-vs-1 and byte 2-vs-3. It corresponds, for YUV422 pixels formats, to swap between UYVY and YUYV.
$00000020 constant DCMIPP_DCMIPP_P0PPCR_PAD                         \ Pad mode for monochrome and raw Bayer 10/12/14 bpp: MSB vs. LSB alignment.
$00000040 constant DCMIPP_DCMIPP_P0PPCR_HEADEREN                    \ CSI header dump enable
$00000180 constant DCMIPP_DCMIPP_P0PPCR_BSM                         \ Byte select mode
$00000200 constant DCMIPP_DCMIPP_P0PPCR_OEBS                        \ Odd/even byte select (byte select start)
$00000400 constant DCMIPP_DCMIPP_P0PPCR_LSM                         \ Line select mode
$00000800 constant DCMIPP_DCMIPP_P0PPCR_OELS                        \ Odd/even line select (line select start)
$0000e000 constant DCMIPP_DCMIPP_P0PPCR_LINEMULT                    \ Amount of capture completed lines for LINE event and interrupt
$00010000 constant DCMIPP_DCMIPP_P0PPCR_DBM                         \ Double buffer mode


\
\ @brief DCMIPP Pipe0 pixel packer Memory0 address register 1
\ Address offset: 0x5C4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P0PPM0AR1_M0A                      \ Memory0 address


\
\ @brief DCMIPP Pipe0 pixel packer Memory0 address register 2
\ Address offset: 0x5C8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P0PPM0AR2_M0A                      \ Memory0 address


\
\ @brief DCMIPP Pipe0 status Memory0 address register
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P0STM0AR_M0A                       \ Memory0 address


\
\ @brief DCMIPP Pipe0 interrupt enable register
\ Address offset: 0x5F4
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P0IER_LINEIE                       \ Multi-line capture completed interrupt enable
$00000002 constant DCMIPP_DCMIPP_P0IER_FRAMEIE                      \ Frame capture completed interrupt enable
$00000004 constant DCMIPP_DCMIPP_P0IER_VSYNCIE                      \ VSYNC interrupt enable
$00000040 constant DCMIPP_DCMIPP_P0IER_LIMITIE                      \ Limit interrupt enable
$00000080 constant DCMIPP_DCMIPP_P0IER_OVRIE                        \ Overrun interrupt enable


\
\ @brief DCMIPP Pipe0 status register
\ Address offset: 0x5F8
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P0SR_LINEF                         \ Multi-line capture completed raw interrupt status
$00000002 constant DCMIPP_DCMIPP_P0SR_FRAMEF                        \ Frame capture completed raw interrupt status
$00000004 constant DCMIPP_DCMIPP_P0SR_VSYNCF                        \ VSYNC raw interrupt status
$00000040 constant DCMIPP_DCMIPP_P0SR_LIMITF                        \ Limit raw interrupt status
$00000080 constant DCMIPP_DCMIPP_P0SR_OVRF                          \ Overrun raw interrupt status
$00010000 constant DCMIPP_DCMIPP_P0SR_LSTLINE                       \ Last line LSB bit, sampled at frame capture complete event.
$00020000 constant DCMIPP_DCMIPP_P0SR_LSTFRM                        \ Last frame LSB bit, sampled at frame capture complete event. The information is extracted from the frame data number that can be delivered by the camera through the CSI2 interface.
$00800000 constant DCMIPP_DCMIPP_P0SR_CPTACT                        \ Capture immediate status


\
\ @brief DCMIPP Pipe0 interrupt clear register
\ Address offset: 0x5FC
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P0FCR_CLINEF                       \ Multi-line capture complete interrupt status clear
$00000002 constant DCMIPP_DCMIPP_P0FCR_CFRAMEF                      \ Frame capture complete interrupt status clear
$00000004 constant DCMIPP_DCMIPP_P0FCR_CVSYNCF                      \ Vertical synchronization interrupt status clear
$00000040 constant DCMIPP_DCMIPP_P0FCR_CLIMITF                      \ limit interrupt status clear
$00000080 constant DCMIPP_DCMIPP_P0FCR_COVRF                        \ Overrun interrupt status clear


\
\ @brief DCMIPP Pipe0 current flow selection configuration register
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$0000003f constant DCMIPP_DCMIPP_P0CFSCR_DTIDA                      \ Current data type selection ID A
$00003f00 constant DCMIPP_DCMIPP_P0CFSCR_DTIDB                      \ Current data type selection ID B
$00030000 constant DCMIPP_DCMIPP_P0CFSCR_DTMODE                     \ Flow selection mode
$00180000 constant DCMIPP_DCMIPP_P0CFSCR_VC                         \ Current flow selection mode
$80000000 constant DCMIPP_DCMIPP_P0CFSCR_PIPEN                      \ Current activation of PipeN


\
\ @brief DCMIPP Pipe0 current flow control configuration register
\ Address offset: 0x700
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P0CFCTCR_FRATE                     \ Frame capture rate control
$00000004 constant DCMIPP_DCMIPP_P0CFCTCR_CPTMODE                   \ Capture mode
$00000008 constant DCMIPP_DCMIPP_P0CFCTCR_CPTREQ                    \ Capture requested


\
\ @brief DCMIPP Pipe0 current stat/crop start register
\ Address offset: 0x704
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P0CSCSTR_HSTART                    \ Current horizontal start, from 0 to 4094 words wide
$0fff0000 constant DCMIPP_DCMIPP_P0CSCSTR_VSTART                    \ Current vertical start, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe0 current stat/crop size register
\ Address offset: 0x708
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P0CSCSZR_HSIZE                     \ Current horizontal size, from 0 to 4094 word wide (data 32-bit).
$0fff0000 constant DCMIPP_DCMIPP_P0CSCSZR_VSIZE                     \ Current vertical size, from 0 to 4094 pixels high.
$40000000 constant DCMIPP_DCMIPP_P0CSCSZR_POSNEG                    \ Current value of the POSNEG bit
$80000000 constant DCMIPP_DCMIPP_P0CSCSZR_ENABLE                    \ Current value of the ENABLE bit


\
\ @brief DCMIPP Pipe0 current pixel packer configuration register
\ Address offset: 0x7C0
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P0CPPCR_SWAPYUV                    \ Swaps, within a 32-bit word, byte 0 vs. 1 and byte 2 vs. 3. It corresponds, for YUV422 pixels formats, to swap between UYVY and YUYV.
$00000020 constant DCMIPP_DCMIPP_P0CPPCR_PAD                        \ Current Pad mode for monochrome and raw Bayer 10/12/14 bpp: MSB vs. LSB alignment
$00000040 constant DCMIPP_DCMIPP_P0CPPCR_HEADEREN                   \ Current CSI header dump enable
$00000180 constant DCMIPP_DCMIPP_P0CPPCR_BSM                        \ Current Byte select mode
$00000200 constant DCMIPP_DCMIPP_P0CPPCR_OEBS                       \ Current odd/even byte select (byte select start)
$00000400 constant DCMIPP_DCMIPP_P0CPPCR_LSM                        \ Current Line select mode
$00000800 constant DCMIPP_DCMIPP_P0CPPCR_OELS                       \ Current odd/even line select (ine select start)
$0000e000 constant DCMIPP_DCMIPP_P0CPPCR_LINEMULT                   \ Current amount of capture completed lines for LINE event and interrupt
$00010000 constant DCMIPP_DCMIPP_P0CPPCR_DBM                        \ Double buffer mode


\
\ @brief DCMIPP Pipe0 current pixel packer Memory0 address register 1
\ Address offset: 0x7C4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P0CPPM0AR1_M0A                     \ Memory0 address


\
\ @brief DCMIPP Pipe0 current pixel packer Memory0 address register 2
\ Address offset: 0x7C8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P0CPPM0AR2_M0A                     \ Memory0 address


\
\ @brief DCMIPP Pipe1 flow selection configuration register
\ Address offset: 0x804
\ Reset value: 0x00000000
\

$0000003f constant DCMIPP_DCMIPP_P1FSCR_DTIDA                       \ Data type selection ID A
$00003f00 constant DCMIPP_DCMIPP_P1FSCR_DTIDB                       \ Data type selection ID B
$00030000 constant DCMIPP_DCMIPP_P1FSCR_DTMODE                      \ Flow selection mode
$00040000 constant DCMIPP_DCMIPP_P1FSCR_PIPEDIFF                    \ Differentiates Pipe2 from Pipe1
$00180000 constant DCMIPP_DCMIPP_P1FSCR_VC                          \ Flow selection mode
$3f000000 constant DCMIPP_DCMIPP_P1FSCR_FDTF                        \ Force Datatype format.
$40000000 constant DCMIPP_DCMIPP_P1FSCR_FDTFEN                      \ Force Datatype format enable.
$80000000 constant DCMIPP_DCMIPP_P1FSCR_PIPEN                       \ Activation of PipeN


\
\ @brief DCMIPP Pipe1 stat removal configuration register
\ Address offset: 0x820
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1SRCR_LASTLINE                    \ Amount of following lines to keep when CROPEN = 1. If LASTLINE = 0 all pixels after FIRSTLINEDEL are fed through.
$00007000 constant DCMIPP_DCMIPP_P1SRCR_FIRSTLINEDEL                \ Amount of first lines to delete when CROPEN = 1
$00008000 constant DCMIPP_DCMIPP_P1SRCR_CROPEN                      \ Crop line enable


\
\ @brief DCMIPP Pipe1 bad pixel removal control register
\ Address offset: 0x824
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1BPRCR_ENABLE                     \ Bad pixel detection must be enabled only for raw Bayer flows, as it corrupts RGB flows.
$0000000e constant DCMIPP_DCMIPP_P1BPRCR_STRENGTH                   \ Strength (aggressiveness) of the bad pixel detection


\
\ @brief DCMIPP Pipe1 bad pixel removal status register
\ Address offset: 0x828
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1BPRSR_BADCNT                     \ Amount of detected bad pixels


\
\ @brief DCMIPP Pipe1 decimation register
\ Address offset: 0x830
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1DECR_ENABLE                      \ None
$00000006 constant DCMIPP_DCMIPP_P1DECR_HDEC                        \ Horizontal decimation ratio
$00000018 constant DCMIPP_DCMIPP_P1DECR_VDEC                        \ Vertical decimation ratio


\
\ @brief DCMIPP Pipe1 black level calibration control register
\ Address offset: 0x840
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1BLCCR_ENABLE                     \ Black level calibration
$0000ff00 constant DCMIPP_DCMIPP_P1BLCCR_BLCB                       \ Black level calibration - Blue
$00ff0000 constant DCMIPP_DCMIPP_P1BLCCR_BLCG                       \ Black level calibration - Green
$ff000000 constant DCMIPP_DCMIPP_P1BLCCR_BLCR                       \ Black level calibration - Red


\
\ @brief DCMIPP Pipe1 exposure control register 1
\ Address offset: 0x844
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1EXCR1_ENABLE                     \ Exposure control (multiplication and shift) of all red, green and blue
$0ff00000 constant DCMIPP_DCMIPP_P1EXCR1_MULTR                      \ Exposure multiplier - Red
$70000000 constant DCMIPP_DCMIPP_P1EXCR1_SHFR                       \ Exposure shift - Red


\
\ @brief DCMIPP Pipe1 exposure control register 2
\ Address offset: 0x848
\ Reset value: 0x00000000
\

$00000ff0 constant DCMIPP_DCMIPP_P1EXCR2_MULTB                      \ Exposure multiplier - Blue
$00007000 constant DCMIPP_DCMIPP_P1EXCR2_SHFB                       \ Exposure shift - Blue
$0ff00000 constant DCMIPP_DCMIPP_P1EXCR2_MULTG                      \ Exposure multiplier - Green
$70000000 constant DCMIPP_DCMIPP_P1EXCR2_SHFG                       \ Exposure shift - Green


\
\ @brief DCMIPP Pipe1 statistics1 control register
\ Address offset: 0x850
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1ST1CR_ENABLE                     \ None
$0000000c constant DCMIPP_DCMIPP_P1ST1CR_BINS                       \ Current bin definition
$00000070 constant DCMIPP_DCMIPP_P1ST1CR_SRC                        \ Statistics source
$00000080 constant DCMIPP_DCMIPP_P1ST1CR_MODE                       \ Statistics mode


\
\ @brief DCMIPP Pipe1 statistics 2 control register
\ Address offset: 0x854
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1ST2CR_ENABLE                     \ None
$0000000c constant DCMIPP_DCMIPP_P1ST2CR_BINS                       \ Bin definition
$00000070 constant DCMIPP_DCMIPP_P1ST2CR_SRC                        \ Statistics source
$00000080 constant DCMIPP_DCMIPP_P1ST2CR_MODE                       \ Statistics mode


\
\ @brief DCMIPP Pipe1 statistics 3 control register
\ Address offset: 0x858
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1ST3CR_ENABLE                     \ None
$0000000c constant DCMIPP_DCMIPP_P1ST3CR_BINS                       \ Bin definition
$00000070 constant DCMIPP_DCMIPP_P1ST3CR_SRC                        \ Statistics source
$00000080 constant DCMIPP_DCMIPP_P1ST3CR_MODE                       \ Statistics mode


\
\ @brief DCMIPP Pipe1 statistics window start register
\ Address offset: 0x85C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1STSTR_HSTART                     \ Horizontal start, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1STSTR_VSTART                     \ Vertical start, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 statistics window size register
\ Address offset: 0x860
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1STSZR_HSIZE                      \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1STSZR_VSIZE                      \ Vertical size, from 0 to 4094 pixels high
$80000000 constant DCMIPP_DCMIPP_P1STSZR_CROPEN                     \ None


\
\ @brief DCMIPP Pipe1 statistics 1 status register
\ Address offset: 0x864
\ Reset value: 0x00000000
\

$00ffffff constant DCMIPP_DCMIPP_P1ST1SR_ACCU                       \ Accumulation result, divided by 256.


\
\ @brief DCMIPP Pipe1 statistics 2 status register
\ Address offset: 0x868
\ Reset value: 0x00000000
\

$00ffffff constant DCMIPP_DCMIPP_P1ST2SR_ACCU                       \ accumulation result, divided by 256.


\
\ @brief DCMIPP Pipe1 statistics 3 status register
\ Address offset: 0x86C
\ Reset value: 0x00000000
\

$00ffffff constant DCMIPP_DCMIPP_P1ST3SR_ACCU                       \ accumulation result, divided by 256.


\
\ @brief DCMIPP Pipe1 demosaicing configuration register
\ Address offset: 0x870
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1DMCR_ENABLE                      \ None
$00000006 constant DCMIPP_DCMIPP_P1DMCR_TYPE                        \ Raw Bayer type
$00070000 constant DCMIPP_DCMIPP_P1DMCR_PEAK                        \ Strength of the peak detection
$00700000 constant DCMIPP_DCMIPP_P1DMCR_LINEV                       \ Strength of the vertical line detection
$07000000 constant DCMIPP_DCMIPP_P1DMCR_LINEH                       \ Strength of the horizontal line detection
$70000000 constant DCMIPP_DCMIPP_P1DMCR_EDGE                        \ Strength of the edge detection


\
\ @brief DCMIPP Pipe1 ColorConv configuration register
\ Address offset: 0x880
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1CCCR_ENABLE                      \ None
$00000002 constant DCMIPP_DCMIPP_P1CCCR_TYPE                        \ output samples type used while CLAMP is activated
$00000004 constant DCMIPP_DCMIPP_P1CCCR_CLAMP                       \ Clamp the output samples


\
\ @brief DCMIPP Pipe1 ColorConv red coefficient register 1
\ Address offset: 0x884
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCRR1_RR                         \ Coefficient row 1 column 1 of the matrix
$07ff0000 constant DCMIPP_DCMIPP_P1CCRR1_RG                         \ Coefficient row 1 column 2 of the matrix


\
\ @brief DCMIPP Pipe1 ColorConv red coefficient register 2
\ Address offset: 0x888
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCRR2_RB                         \ Coefficient row 1 column 3 of the matrix
$03ff0000 constant DCMIPP_DCMIPP_P1CCRR2_RA                         \ Coefficient row 1 of the added column (signed integer value)


\
\ @brief DCMIPP Pipe1 ColorConv green coefficient register 1
\ Address offset: 0x88C
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCGR1_GR                         \ Coefficient row 2 column 1 of the matrix
$07ff0000 constant DCMIPP_DCMIPP_P1CCGR1_GG                         \ Coefficient row 2 column 2 of the matrix


\
\ @brief DCMIPP Pipe1 ColorConv green coefficient register 2
\ Address offset: 0x890
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCGR2_GB                         \ Coefficient row 2 column 3 of the matrix
$03ff0000 constant DCMIPP_DCMIPP_P1CCGR2_GA                         \ Coefficient row 2 of the added column (signed integer value)


\
\ @brief DCMIPP Pipex ColorConv blue coefficient register 1
\ Address offset: 0x894
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCBR1_BR                         \ Coefficient row 3 column 1 of the matrix
$07ff0000 constant DCMIPP_DCMIPP_P1CCBR1_BG                         \ Coefficient row 3 column 2 of the matrix


\
\ @brief DCMIPP Pipe1 ColorConv blue coefficient register 2
\ Address offset: 0x898
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCBR2_BB                         \ Coefficient row 3 column 3 of the matrix
$03ff0000 constant DCMIPP_DCMIPP_P1CCBR2_BA                         \ Coefficient row 3 of the added column (signed integer value)


\
\ @brief DCMIPP Pipe1 contrast control register 1
\ Address offset: 0x8A0
\ Reset value: 0x00002000
\

$00000001 constant DCMIPP_DCMIPP_P1CTCR1_ENABLE                     \ None
$00007e00 constant DCMIPP_DCMIPP_P1CTCR1_LUM0                       \ Luminance increase for input luminance of 0 (increase is idle with LUMx = 16)


\
\ @brief DCMIPP Pipe1 contrast control register 2
\ Address offset: 0x8A4
\ Reset value: 0x20202020
\

$0000007e constant DCMIPP_DCMIPP_P1CTCR2_LUM4                       \ Luminance increase for input luminance of 128 (increase is idle with LUMx = 16)
$00007e00 constant DCMIPP_DCMIPP_P1CTCR2_LUM3                       \ Luminance increase for input luminance of 96 (increase is idle with LUMx = 16)
$007e0000 constant DCMIPP_DCMIPP_P1CTCR2_LUM2                       \ Luminance increase for input luminance of 64 (increase is idle with LUMx = 16)
$7e000000 constant DCMIPP_DCMIPP_P1CTCR2_LUM1                       \ Luminance increase for input luminance of 32 (increase is idle with LUMx = 16)


\
\ @brief DCMIPP Pipe1 contrast control register 3
\ Address offset: 0x8A8
\ Reset value: 0x20202020
\

$0000007e constant DCMIPP_DCMIPP_P1CTCR3_LUM8                       \ Luminance increase for input luminance of 256 (increase is idle with LUMx = 16)
$00007e00 constant DCMIPP_DCMIPP_P1CTCR3_LUM7                       \ Luminance increase for input luminance of 224 (increase is idle with LUMx = 16)
$007e0000 constant DCMIPP_DCMIPP_P1CTCR3_LUM6                       \ Luminance increase for input luminance of 192 (increase is idle with LUMx = 16)
$7e000000 constant DCMIPP_DCMIPP_P1CTCR3_LUM5                       \ Luminance increase for input luminance of 160 (increase is idle with LUMx = 16)


\
\ @brief DCMIPP Pipex flow control configuration register
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P1FCTCR_FRATE                      \ Frame capture rate control
$00000004 constant DCMIPP_DCMIPP_P1FCTCR_CPTMODE                    \ Capture mode
$00000008 constant DCMIPP_DCMIPP_P1FCTCR_CPTREQ                     \ Capture requested


\
\ @brief DCMIPP Pipex crop window start register
\ Address offset: 0x904
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRSTR_HSTART                     \ Horizontal start, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CRSTR_VSTART                     \ Vertical start, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipex crop window size register
\ Address offset: 0x908
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRSZR_HSIZE                      \ Horizontal size, from 0 to 4094 pixels wide. If the value is maintained at 0 when enabling the crop by means of the ENABLE bit, the value is forced internally at 0xFFE, which is the maximum value.
$0fff0000 constant DCMIPP_DCMIPP_P1CRSZR_VSIZE                      \ Vertical size, from 0 to 4094 pixels high. If the value is maintained at 0 when enabling the crop thanks to the ENABLE bit, the value is forced internally at 0xFFE, which is the maximum value.
$80000000 constant DCMIPP_DCMIPP_P1CRSZR_ENABLE                     \ None


\
\ @brief DCMIPP Pipex decimation register
\ Address offset: 0x90C
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1DCCR_ENABLE                      \ None
$00000006 constant DCMIPP_DCMIPP_P1DCCR_HDEC                        \ Horizontal decimation ratio
$00000018 constant DCMIPP_DCMIPP_P1DCCR_VDEC                        \ Vertical decimation ratio


\
\ @brief DCMIPP Pipex downsize configuration register
\ Address offset: 0x910
\ Reset value: 0x00000000
\

$000003ff constant DCMIPP_DCMIPP_P1DSCR_HDIV                        \ Horizontal division factor, from 128 (8x) to 1023 (1x)
$03ff0000 constant DCMIPP_DCMIPP_P1DSCR_VDIV                        \ Vertical division factor, from 128 (8x) to 1023 (1x)
$80000000 constant DCMIPP_DCMIPP_P1DSCR_ENABLE                      \ None


\
\ @brief DCMIPP Pipex downsize ratio register
\ Address offset: 0x914
\ Reset value: 0x00000000
\

$0000ffff constant DCMIPP_DCMIPP_P1DSRTIOR_HRATIO                   \ Horizontal ratio, from 8192 (1x) to 65535 (8x)
$ffff0000 constant DCMIPP_DCMIPP_P1DSRTIOR_VRATIO                   \ Vertical ratio, from 8192 (1x) to 65535 (8x)


\
\ @brief DCMIPP Pipex downsize destination size register
\ Address offset: 0x918
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1DSSZR_HSIZE                      \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1DSSZR_VSIZE                      \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipex common ROI configuration register
\ Address offset: 0x920
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P1CMRICR_ROILSZ                    \ Region of interest line size width
$00010000 constant DCMIPP_DCMIPP_P1CMRICR_ROI1EN                    \ Region of interest 1 enable
$00020000 constant DCMIPP_DCMIPP_P1CMRICR_ROI2EN                    \ Region of interest 2 enable
$00040000 constant DCMIPP_DCMIPP_P1CMRICR_ROI3EN                    \ Region of interest 3 enable
$00080000 constant DCMIPP_DCMIPP_P1CMRICR_ROI4EN                    \ Region of interest 4 enable
$00100000 constant DCMIPP_DCMIPP_P1CMRICR_ROI5EN                    \ Region of interest 5 enable
$00200000 constant DCMIPP_DCMIPP_P1CMRICR_ROI6EN                    \ Region of interest 6 enable
$00400000 constant DCMIPP_DCMIPP_P1CMRICR_ROI7EN                    \ Region of interest 7 enable
$00800000 constant DCMIPP_DCMIPP_P1CMRICR_ROI8EN                    \ Region of interest 8 enable


\
\ @brief DCMIPP Pipe1 ROI1 configuration register 1
\ Address offset: 0x924
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI1CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1RI1CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P1RI1CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P1RI1CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1RI1CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe1 ROI1 configuration register 2
\ Address offset: 0x928
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI1CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1RI1CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 ROI2 configuration register 1
\ Address offset: 0x92C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI2CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1RI2CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P1RI2CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P1RI2CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1RI2CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe1 ROI2 configuration register 2
\ Address offset: 0x930
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI2CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1RI2CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 ROI3 configuration register 1
\ Address offset: 0x934
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI3CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1RI3CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P1RI3CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P1RI3CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1RI3CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe1 ROI3 configuration register 2
\ Address offset: 0x938
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI3CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1RI3CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 ROI4 configuration register 1
\ Address offset: 0x93C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI4CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1RI4CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P1RI4CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P1RI4CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1RI4CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe1 ROI4 configuration register 2
\ Address offset: 0x940
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI4CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1RI4CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 ROI5 configuration register 1
\ Address offset: 0x944
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI5CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1RI5CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P1RI5CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P1RI5CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1RI5CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe1 ROI5 configuration register 2
\ Address offset: 0x948
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI5CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1RI5CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 ROI6 configuration register 1
\ Address offset: 0x94C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI6CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1RI6CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P1RI6CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P1RI6CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1RI6CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe1 ROI6 configuration register 2
\ Address offset: 0x950
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI6CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1RI6CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 ROI7 configuration register 1
\ Address offset: 0x954
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI7CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1RI7CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P1RI7CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P1RI7CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1RI7CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe1 ROI7 configuration register 2
\ Address offset: 0x958
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI7CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1RI7CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 ROI8 configuration register 1
\ Address offset: 0x95C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI8CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1RI8CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P1RI8CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P1RI8CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1RI8CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe1 ROI8 configuration register 2
\ Address offset: 0x960
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1RI8CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1RI8CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipex gamma configuration register
\ Address offset: 0x970
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1GMCR_ENABLE                      \ None


\
\ @brief DCMIPP Pipe1 YUVConv configuration register
\ Address offset: 0x980
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1YUVCR_ENABLE                     \ None
$00000002 constant DCMIPP_DCMIPP_P1YUVCR_TYPE                       \ Output samples type used while CLAMP is activated
$00000004 constant DCMIPP_DCMIPP_P1YUVCR_CLAMP                      \ Clamp the output samples


\
\ @brief DCMIPP Pipe1 YUVConv red coefficient register 1
\ Address offset: 0x984
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1YUVRR1_RR                        \ Coefficient row 1 column 1 of the matrix
$07ff0000 constant DCMIPP_DCMIPP_P1YUVRR1_RG                        \ Coefficient row 1 column 2 of the matrix


\
\ @brief DCMIPP Pipe1 YUVConv red coefficient register 2
\ Address offset: 0x988
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1YUVRR2_RB                        \ Coefficient row 1 column 3 of the matrix
$03ff0000 constant DCMIPP_DCMIPP_P1YUVRR2_RA                        \ Coefficient row 1 of the added column (signed integer value)


\
\ @brief DCMIPP Pipe1 YUVConv green coefficient register 1
\ Address offset: 0x98C
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1YUVGR1_GR                        \ Coefficient row 2 column 1 of the matrix
$07ff0000 constant DCMIPP_DCMIPP_P1YUVGR1_GG                        \ Coefficient row 2 column 2 of the matrix


\
\ @brief DCMIPP Pipe1 YUVConv green coefficient register 2
\ Address offset: 0x990
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1YUVGR2_GB                        \ Coefficient row 2 column 3 of the matrix
$03ff0000 constant DCMIPP_DCMIPP_P1YUVGR2_GA                        \ Coefficient row 2 of the added column (signed integer value)


\
\ @brief DCMIPP Pipe1 YUVConv blue coefficient register 1
\ Address offset: 0x994
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1YUVBR1_BR                        \ Coefficient row 3 column 1 of the matrix
$07ff0000 constant DCMIPP_DCMIPP_P1YUVBR1_BG                        \ Coefficient row 3 column 2 of the matrix


\
\ @brief DCMIPP Pipe1 YUV blue coefficient register 2
\ Address offset: 0x998
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1YUVBR2_BB                        \ Coefficient row 3 column 3 of the matrix
$03ff0000 constant DCMIPP_DCMIPP_P1YUVBR2_BA                        \ Coefficient row 3 of the added column (signed integer value)


\
\ @brief DCMIPP Pipe1 pixel packer configuration register
\ Address offset: 0x9C0
\ Reset value: 0x00000000
\

$0000000f constant DCMIPP_DCMIPP_P1PPCR_FORMAT                      \ Memory format
$00000010 constant DCMIPP_DCMIPP_P1PPCR_SWAPRB                      \ Swaps R-vs-B components if RGB, and U-vs-V components if YUV
$0000e000 constant DCMIPP_DCMIPP_P1PPCR_LINEMULT                    \ Amount of capture completed lines for LINE Event and Interrupt
$00010000 constant DCMIPP_DCMIPP_P1PPCR_DBM                         \ Double buffer mode
$000e0000 constant DCMIPP_DCMIPP_P1PPCR_LMAWM                       \ Line multi address wrapping modulo.
$00100000 constant DCMIPP_DCMIPP_P1PPCR_LMAWE                       \ Line multi address wrapping enable bit.


\
\ @brief DCMIPP Pipe1 pixel packer Memory0 address register 1
\ Address offset: 0x9C4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1PPM0AR1_M0A                      \ Memory0 address


\
\ @brief DCMIPP Pipe1 pixel packer Memory0 address register 2
\ Address offset: 0x9C8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1PPM0AR2_M0A                      \ Memory0 address


\
\ @brief DCMIPP Pipex pixel packer Memory0 pitch register
\ Address offset: 0x9CC
\ Reset value: 0x00000000
\

$00007fff constant DCMIPP_DCMIPP_P1PPM0PR_PITCH                     \ Number of bytes between the address of two consecutive lines.


\
\ @brief DCMIPP Pipex status Memory0 address register
\ Address offset: 0x9D0
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1STM0AR_M0A                       \ Memory0 address


\
\ @brief DCMIPP Pipex pixel packer Memory1 address register 1
\ Address offset: 0x9D4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1PPM1AR1_M1A                      \ Memory1 address


\
\ @brief DCMIPP Pipex pixel packer Memory1 address register 2
\ Address offset: 0x9D8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1PPM1AR2_M1A                      \ Memory1 address


\
\ @brief DCMIPP Pipex pixel packer Memory1 pitch register
\ Address offset: 0x9DC
\ Reset value: 0x00000000
\

$00007fff constant DCMIPP_DCMIPP_P1PPM1PR_PITCH                     \ Number of bytes between the address of two consecutive lines.


\
\ @brief DCMIPP Pipex status Memory1 address register
\ Address offset: 0x9E0
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1STM1AR_M1A                       \ Memory1 address


\
\ @brief DCMIPP Pipex pixel packer memory2 address register 1
\ Address offset: 0x9E4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1PPM2AR1_M2A                      \ Memory 2 address


\
\ @brief DCMIPP Pipex pixel packer memory2 address register 2
\ Address offset: 0x9E8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1PPM2AR2_M2A                      \ Memory 2 address


\
\ @brief DCMIPP Pipex status Memory2 address register
\ Address offset: 0x9F0
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1STM2AR_M2A                       \ Memory2 address


\
\ @brief DCMIPP Pipe1 interrupt enable register
\ Address offset: 0x9F4
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1IER_LINEIE                       \ Multi-line capture completed interrupt enable
$00000002 constant DCMIPP_DCMIPP_P1IER_FRAMEIE                      \ Frame capture completed interrupt enable
$00000004 constant DCMIPP_DCMIPP_P1IER_VSYNCIE                      \ VSYNC interrupt enable
$00000080 constant DCMIPP_DCMIPP_P1IER_OVRIE                        \ Overrun interrupt enable


\
\ @brief DCMIPP Pipe1 status register
\ Address offset: 0x9F8
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1SR_LINEF                         \ Multi-line capture completed raw interrupt status
$00000002 constant DCMIPP_DCMIPP_P1SR_FRAMEF                        \ Frame capture completed raw interrupt status
$00000004 constant DCMIPP_DCMIPP_P1SR_VSYNCF                        \ VSYNC raw interrupt status
$00000080 constant DCMIPP_DCMIPP_P1SR_OVRF                          \ Overrun raw interrupt status
$00010000 constant DCMIPP_DCMIPP_P1SR_LSTLINE                       \ Last line LSB bit, sampled at frame capture complete event.
$00020000 constant DCMIPP_DCMIPP_P1SR_LSTFRM                        \ Last frame LSB bit, sampled at frame capture complete event. The information is extracted from the frame data number, which can be delivered by the camera through the CSI2 interface.
$00800000 constant DCMIPP_DCMIPP_P1SR_CPTACT                        \ Capture immediate status


\
\ @brief DCMIPP Pipe1 interrupt clear register
\ Address offset: 0x9FC
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1FCR_CLINEF                       \ Multi-line capture complete interrupt status clear
$00000002 constant DCMIPP_DCMIPP_P1FCR_CFRAMEF                      \ Frame capture complete interrupt status clear
$00000004 constant DCMIPP_DCMIPP_P1FCR_CVSYNCF                      \ Vertical synchronization interrupt status clear
$00000080 constant DCMIPP_DCMIPP_P1FCR_COVRF                        \ Overrun interrupt status clear


\
\ @brief DCMIPP Pipe1 current flow selection configuration register
\ Address offset: 0xA04
\ Reset value: 0x00000000
\

$0000003f constant DCMIPP_DCMIPP_P1CFSCR_DTIDA                      \ Current data type ID A
$00003f00 constant DCMIPP_DCMIPP_P1CFSCR_DTIDB                      \ Current data type ID B
$00030000 constant DCMIPP_DCMIPP_P1CFSCR_DTMODE                     \ Flow selection mode
$00040000 constant DCMIPP_DCMIPP_P1CFSCR_PIPEDIFF                   \ Current differentiates Pipe2 vs. Pipe1
$00180000 constant DCMIPP_DCMIPP_P1CFSCR_VC                         \ Current flow selection mode
$3f000000 constant DCMIPP_DCMIPP_P1CFSCR_FDTF                       \ Current force data type format
$40000000 constant DCMIPP_DCMIPP_P1CFSCR_FDTFEN                     \ Current force data type format enable
$80000000 constant DCMIPP_DCMIPP_P1CFSCR_PIPEN                      \ Current activation of PipeN


\
\ @brief DCMIPP Pipe1 current bad pixel removal register
\ Address offset: 0xA24
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1CBPRCR_ENABLE                    \ Current status of enable bit
$0000000e constant DCMIPP_DCMIPP_P1CBPRCR_STRENGTH                  \ Current strength (aggressiveness) of the bad pixel detection:


\
\ @brief DCMIPP Pipe1 current black level calibration control register
\ Address offset: 0xA40
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1CBLCCR_ENABLE                    \ For current black level calibration
$0000ff00 constant DCMIPP_DCMIPP_P1CBLCCR_BLCB                      \ Current black level calibration - Blue
$00ff0000 constant DCMIPP_DCMIPP_P1CBLCCR_BLCG                      \ Current black level calibration - Green
$ff000000 constant DCMIPP_DCMIPP_P1CBLCCR_BLCR                      \ Current black level calibration - Red


\
\ @brief DCMIPP Pipe1 current exposure control register 1
\ Address offset: 0xA44
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1CEXCR1_ENABLE                    \ for exposure control (multiplication and shift)
$0ff00000 constant DCMIPP_DCMIPP_P1CEXCR1_MULTR                     \ Current exposure multiplier - Red
$70000000 constant DCMIPP_DCMIPP_P1CEXCR1_SHFR                      \ Current exposure shift - Red


\
\ @brief DCMIPP Pipe1 current exposure control register 2
\ Address offset: 0xA48
\ Reset value: 0x00000000
\

$00000ff0 constant DCMIPP_DCMIPP_P1CEXCR2_MULTB                     \ Current exposure multiplier - Blue
$00007000 constant DCMIPP_DCMIPP_P1CEXCR2_SHFB                      \ Current exposure shift - Blue
$0ff00000 constant DCMIPP_DCMIPP_P1CEXCR2_MULTG                     \ Current exposure multiplier - Green
$70000000 constant DCMIPP_DCMIPP_P1CEXCR2_SHFG                      \ Current exposure shift - Green


\
\ @brief DCMIPP Pipe1 current statistics 1 control register
\ Address offset: 0xA50
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1CST1CR_ENABLE                    \ Current enable bit value
$0000000c constant DCMIPP_DCMIPP_P1CST1CR_BINS                      \ Current bin definition
$00000070 constant DCMIPP_DCMIPP_P1CST1CR_SRC                       \ Current source of statistics
$00000080 constant DCMIPP_DCMIPP_P1CST1CR_MODE                      \ Current statistics mode
$ffffff00 constant DCMIPP_DCMIPP_P1CST1CR_ACCU                      \ Current accumulation result, divided by 256.


\
\ @brief DCMIPP Pipe1 current statistics 2 control register
\ Address offset: 0xA54
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1CST2CR_ENABLE                    \ None
$0000000c constant DCMIPP_DCMIPP_P1CST2CR_BINS                      \ Bin definition
$00000070 constant DCMIPP_DCMIPP_P1CST2CR_SRC                       \ Statistics source
$00000080 constant DCMIPP_DCMIPP_P1CST2CR_MODE                      \ Statistics mode
$ffffff00 constant DCMIPP_DCMIPP_P1CST2CR_ACCU                      \ Accumulation result, divided by 256.


\
\ @brief DCMIPP Pipe1 current statistics 3 control register
\ Address offset: 0xA58
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1CST3CR_ENABLE                    \ None
$0000000c constant DCMIPP_DCMIPP_P1CST3CR_BINS                      \ Current bin definition
$00000070 constant DCMIPP_DCMIPP_P1CST3CR_SRC                       \ Statistics source
$00000080 constant DCMIPP_DCMIPP_P1CST3CR_MODE                      \ Statistics mode
$ffffff00 constant DCMIPP_DCMIPP_P1CST3CR_ACCU                      \ Accumulation result, divided by 256.


\
\ @brief DCMIPP Pipe1 current statistics window start register
\ Address offset: 0xA5C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CSTSTR_HSTART                    \ Current horizontal start, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CSTSTR_VSTART                    \ Current vertical start, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 current statistics window size register
\ Address offset: 0xA60
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CSTSZR_HSIZE                     \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CSTSZR_VSIZE                     \ Current vertical size, from 0 to 4094 pixels high
$80000000 constant DCMIPP_DCMIPP_P1CSTSZR_CROPEN                    \ Current CROPEN bit value


\
\ @brief DCMIPP Pipe1 current ColorConv configuration register
\ Address offset: 0xA80
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1CCCCR_ENABLE                     \ Current value applied
$00000002 constant DCMIPP_DCMIPP_P1CCCCR_TYPE                       \ Output samples type used while CLAMP is activated
$00000004 constant DCMIPP_DCMIPP_P1CCCCR_CLAMP                      \ Clamp the output samples


\
\ @brief DCMIPP Pipe1 current ColorConv red coefficient register 1
\ Address offset: 0xA84
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCCRR1_RR                        \ Current coefficient row 1 column 1 of the matrix
$07ff0000 constant DCMIPP_DCMIPP_P1CCCRR1_RG                        \ Current coefficient row 1 column 2 of the matrix


\
\ @brief DCMIPP Pipe1 current ColorConv red coefficient register 2
\ Address offset: 0xA88
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCCRR2_RB                        \ Current coefficient row 1 column 3 of the matrix
$03ff0000 constant DCMIPP_DCMIPP_P1CCCRR2_RA                        \ Current coefficient row 1 of the added column (signed integer value)


\
\ @brief DCMIPP Pipe1 current ColorConv green coefficient register 1
\ Address offset: 0xA8C
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCCGR1_GR                        \ Current coefficient row 2 column 1 of the matrix
$07ff0000 constant DCMIPP_DCMIPP_P1CCCGR1_GG                        \ Current coefficient row 2 column 2 of the matrix


\
\ @brief DCMIPP Pipe1 current ColorConv green coefficient register 2
\ Address offset: 0xA90
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCCGR2_GB                        \ Current coefficient row 2 column 3 of the matrix
$03ff0000 constant DCMIPP_DCMIPP_P1CCCGR2_GA                        \ Current coefficient row 2 of the added column (signed integer value)


\
\ @brief DCMIPP Pipex current ColorConv blue coefficient register 1
\ Address offset: 0xA94
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCCBR1_BR                        \ Current coefficient row 3 column 1 of the matrix
$07ff0000 constant DCMIPP_DCMIPP_P1CCCBR1_BG                        \ Current coefficient row 3 column 2 of the matrix


\
\ @brief DCMIPP Pipe1 current ColorConv blue coefficient register 2
\ Address offset: 0xA98
\ Reset value: 0x00000000
\

$000007ff constant DCMIPP_DCMIPP_P1CCCBR2_BB                        \ Current coefficient row 3 column 3 of the matrix
$03ff0000 constant DCMIPP_DCMIPP_P1CCCBR2_BA                        \ Current coefficient row 3 of the added column (signed integer value)


\
\ @brief DCMIPP Pipe1 current contrast control register 1
\ Address offset: 0xAA0
\ Reset value: 0x00002000
\

$00000001 constant DCMIPP_DCMIPP_P1CCTCR1_ENABLE                    \ Current ENABLE bit value
$00007e00 constant DCMIPP_DCMIPP_P1CCTCR1_LUM0                      \ Current luminance increase for input luminance of 0 (increase is idle with LUMx = 16)


\
\ @brief DCMIPP Pipe1 current contrast control register 2
\ Address offset: 0xAA4
\ Reset value: 0x20202020
\

$0000007e constant DCMIPP_DCMIPP_P1CCTCR2_LUM4                      \ Current luminance increase for input luminance of 128 (increase is idle with LUMx = 16)
$00007e00 constant DCMIPP_DCMIPP_P1CCTCR2_LUM3                      \ Current luminance increase for input luminance of 96 (increase is idle with LUMx = 16)
$007e0000 constant DCMIPP_DCMIPP_P1CCTCR2_LUM2                      \ Current luminance increase for input luminance of 64 (increase is idle with LUMx = 16)
$7e000000 constant DCMIPP_DCMIPP_P1CCTCR2_LUM1                      \ Current luminance increase for input luminance of 32 (increase is idle with LUMx = 16)


\
\ @brief DCMIPP Pipe1 current contrast control register 3
\ Address offset: 0xAA8
\ Reset value: 0x20202020
\

$0000007e constant DCMIPP_DCMIPP_P1CCTCR3_LUM8                      \ Luminance increase for input luminance of 256 (increase is idle with LUMx = 16)
$00007e00 constant DCMIPP_DCMIPP_P1CCTCR3_LUM7                      \ Luminance increase for input luminance of 224 (increase is idle with LUMx = 16)
$007e0000 constant DCMIPP_DCMIPP_P1CCTCR3_LUM6                      \ Luminance increase for input luminance of 192 (increase is idle with LUMx = 16)
$7e000000 constant DCMIPP_DCMIPP_P1CCTCR3_LUM5                      \ Luminance increase for input luminance of 160 (increase is idle with LUMx = 16)


\
\ @brief DCMIPP Pipex current flow control configuration register
\ Address offset: 0xB00
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P1CFCTCR_FRATE                     \ Frame capture rate control
$00000004 constant DCMIPP_DCMIPP_P1CFCTCR_CPTMODE                   \ Capture mode
$00000008 constant DCMIPP_DCMIPP_P1CFCTCR_CPTREQ                    \ Capture requested


\
\ @brief DCMIPP Pipex current crop window start register
\ Address offset: 0xB04
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CCRSTR_HSTART                    \ Current horizontal start, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CCRSTR_VSTART                    \ Current vertical start, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipex current crop window size register
\ Address offset: 0xB08
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CCRSZR_HSIZE                     \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CCRSZR_VSIZE                     \ Current vertical size, from 0 to 4094 pixels high
$80000000 constant DCMIPP_DCMIPP_P1CCRSZR_ENABLE                    \ Current ENABLE bit value.


\
\ @brief DCMIPP Pipex current decimation register
\ Address offset: 0xB0C
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P1CDCCR_ENABLE                     \ None
$00000006 constant DCMIPP_DCMIPP_P1CDCCR_HDEC                       \ Horizontal decimation ratio
$00000018 constant DCMIPP_DCMIPP_P1CDCCR_VDEC                       \ Vertical decimation ratio


\
\ @brief DCMIPP Pipex current downsize configuration register
\ Address offset: 0xB10
\ Reset value: 0x00000000
\

$000003ff constant DCMIPP_DCMIPP_P1CDSCR_HDIV                       \ Current horizontal division factor, from 128 (8x) to 1023 (1x)
$03ff0000 constant DCMIPP_DCMIPP_P1CDSCR_VDIV                       \ Current vertical division factor, from 128 (8x) to 1023 (1x)
$80000000 constant DCMIPP_DCMIPP_P1CDSCR_ENABLE                     \ Current value of bit ENABLE


\
\ @brief DCMIPP Pipex current downsize ratio register
\ Address offset: 0xB14
\ Reset value: 0x00000000
\

$0000ffff constant DCMIPP_DCMIPP_P1CDSRTIOR_HRATIO                  \ Current horizontal ratio, from 8192 (1x) to 65535 (8x)
$ffff0000 constant DCMIPP_DCMIPP_P1CDSRTIOR_VRATIO                  \ Current vertical ratio, from 8192 (1x) to 65535 (8x)


\
\ @brief DCMIPP Pipex current downsize destination size register
\ Address offset: 0xB18
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CDSSZR_HSIZE                     \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CDSSZR_VSIZE                     \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipex current common ROI configuration register
\ Address offset: 0xB20
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P1CCMRICR_ROILSZ                   \ Current region of interest line size width
$00010000 constant DCMIPP_DCMIPP_P1CCMRICR_ROI1EN                   \ Current region of interest 1 enable
$00020000 constant DCMIPP_DCMIPP_P1CCMRICR_ROI2EN                   \ Current region of interest 2 enable
$00040000 constant DCMIPP_DCMIPP_P1CCMRICR_ROI3EN                   \ Current region of interest 3 enable
$00080000 constant DCMIPP_DCMIPP_P1CCMRICR_ROI4EN                   \ Current region of interest 4 enable
$00100000 constant DCMIPP_DCMIPP_P1CCMRICR_ROI5EN                   \ Current region of interest 5 enable
$00200000 constant DCMIPP_DCMIPP_P1CCMRICR_ROI6EN                   \ Current region of interest 6 enable
$00400000 constant DCMIPP_DCMIPP_P1CCMRICR_ROI7EN                   \ Current region of interest 7 enable
$00800000 constant DCMIPP_DCMIPP_P1CCMRICR_ROI8EN                   \ Current region of interest 8 enable


\
\ @brief DCMIPP Pipe1 current ROI1 configuration register 1
\ Address offset: 0xB24
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI1CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1CRI1CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P1CRI1CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P1CRI1CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1CRI1CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe1 current ROI1 configuration register 2
\ Address offset: 0xB28
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI1CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CRI1CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 current ROI2 configuration register 1
\ Address offset: 0xB2C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI2CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1CRI2CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P1CRI2CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P1CRI2CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1CRI2CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe1 current ROI2 configuration register 2
\ Address offset: 0xB30
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI2CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CRI2CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 current ROI3 configuration register 1
\ Address offset: 0xB34
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI3CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1CRI3CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P1CRI3CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P1CRI3CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1CRI3CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe1 current ROI3 configuration register 2
\ Address offset: 0xB38
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI3CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CRI3CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 current ROI4 configuration register 1
\ Address offset: 0xB3C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI4CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1CRI4CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P1CRI4CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P1CRI4CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1CRI4CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe1 current ROI4 configuration register 2
\ Address offset: 0xB40
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI4CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CRI4CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 current ROI5 configuration register 1
\ Address offset: 0xB44
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI5CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1CRI5CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P1CRI5CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P1CRI5CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1CRI5CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe1 current ROI5 configuration register 2
\ Address offset: 0xB48
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI5CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CRI5CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 current ROI6 configuration register 1
\ Address offset: 0xB4C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI6CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1CRI6CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P1CRI6CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P1CRI6CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1CRI6CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe1 current ROI6 configuration register 2
\ Address offset: 0xB50
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI6CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CRI6CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 current ROI7 configuration register 1
\ Address offset: 0xB54
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI7CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1CRI7CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P1CRI7CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P1CRI7CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1CRI7CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe1 current ROI7 configuration register 2
\ Address offset: 0xB58
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI7CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CRI7CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 current ROI8 configuration register 1
\ Address offset: 0xB5C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI8CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P1CRI8CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P1CRI8CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P1CRI8CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P1CRI8CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe1 current ROI8 configuration register 2
\ Address offset: 0xB60
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P1CRI8CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P1CRI8CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe1 current pixel packer configuration register
\ Address offset: 0xBC0
\ Reset value: 0x00000000
\

$0000000f constant DCMIPP_DCMIPP_P1CPPCR_FORMAT                     \ Memory format
$00000010 constant DCMIPP_DCMIPP_P1CPPCR_SWAPRB                     \ Swaps R-vs-B components if RGB, and U-vs-V components if YUV
$0000e000 constant DCMIPP_DCMIPP_P1CPPCR_LINEMULT                   \ Amount of capture completed lines for LINE Event and Interrupt
$00010000 constant DCMIPP_DCMIPP_P1CPPCR_DBM                        \ Double buffer mode
$000e0000 constant DCMIPP_DCMIPP_P1CPPCR_LMAWM                      \ Line multi address wrapping modulo
$00100000 constant DCMIPP_DCMIPP_P1CPPCR_LMAWE                      \ Line multi address wrapping enable bit


\
\ @brief DCMIPP Pipe1 current pixel packer Memory0 address register 1
\ Address offset: 0xBC4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1CPPM0AR1_M0A                     \ Memory0 address


\
\ @brief DCMIPP Pipe1 current pixel packer Memory0 address register 2
\ Address offset: 0xBC8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1CPPM0AR2_M0A                     \ Memory0 address


\
\ @brief DCMIPP Pipex current pixel packer Memory0 pitch register
\ Address offset: 0xBCC
\ Reset value: 0x00000000
\

$00007fff constant DCMIPP_DCMIPP_P1CPPM0PR_PITCH                    \ Current number of bytes between the address of two consecutive lines.


\
\ @brief DCMIPP Pipex current pixel packer Memory1 address register 1
\ Address offset: 0xBD4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1CPPM1AR1_M1A                     \ Memory1 address


\
\ @brief DCMIPP Pipex current pixel packer Memory1 address register 2
\ Address offset: 0xBD8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1CPPM1AR2_M1A                     \ Memory1 address


\
\ @brief DCMIPP Pipex current pixel packer Memory1 pitch register
\ Address offset: 0xBDC
\ Reset value: 0x00000000
\

$00007fff constant DCMIPP_DCMIPP_P1CPPM1PR_PITCH                    \ Current number of bytes between the address of two consecutive lines


\
\ @brief DCMIPP Pipex current pixel packer Memory2 address register 1
\ Address offset: 0xBE4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1CPPM2AR1_M2A                     \ Memory 2 address


\
\ @brief DCMIPP Pipex current pixel packer Memory2 address register 1
\ Address offset: 0xBE8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P1CPPM2AR2_M2A                     \ Memory 2 address


\
\ @brief DCMIPP Pipe2 flow selection configuration register
\ Address offset: 0xC04
\ Reset value: 0x00000000
\

$0000003f constant DCMIPP_DCMIPP_P2FSCR_DTIDA                       \ Data type ID
$00180000 constant DCMIPP_DCMIPP_P2FSCR_VC                          \ Flow selection mode
$3f000000 constant DCMIPP_DCMIPP_P2FSCR_FDTF                        \ Force data type format
$40000000 constant DCMIPP_DCMIPP_P2FSCR_FDTFEN                      \ Force data type format enable
$80000000 constant DCMIPP_DCMIPP_P2FSCR_PIPEN                       \ Activation of PipeN


\
\ @brief DCMIPP Pipex flow control configuration register
\ Address offset: 0xD00
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P2FCTCR_FRATE                      \ Frame capture rate control
$00000004 constant DCMIPP_DCMIPP_P2FCTCR_CPTMODE                    \ Capture mode
$00000008 constant DCMIPP_DCMIPP_P2FCTCR_CPTREQ                     \ Capture requested


\
\ @brief DCMIPP Pipex crop window start register
\ Address offset: 0xD04
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRSTR_HSTART                     \ Horizontal start, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CRSTR_VSTART                     \ Vertical start, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipex crop window size register
\ Address offset: 0xD08
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRSZR_HSIZE                      \ Horizontal size, from 0 to 4094 pixels wide. If the value is maintained at 0 when enabling the crop by means of the ENABLE bit, the value is forced internally at 0xFFE, which is the maximum value.
$0fff0000 constant DCMIPP_DCMIPP_P2CRSZR_VSIZE                      \ Vertical size, from 0 to 4094 pixels high. If the value is maintained at 0 when enabling the crop thanks to the ENABLE bit, the value is forced internally at 0xFFE, which is the maximum value.
$80000000 constant DCMIPP_DCMIPP_P2CRSZR_ENABLE                     \ None


\
\ @brief DCMIPP Pipex decimation register
\ Address offset: 0xD0C
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P2DCCR_ENABLE                      \ None
$00000006 constant DCMIPP_DCMIPP_P2DCCR_HDEC                        \ Horizontal decimation ratio
$00000018 constant DCMIPP_DCMIPP_P2DCCR_VDEC                        \ Vertical decimation ratio


\
\ @brief DCMIPP Pipex downsize configuration register
\ Address offset: 0xD10
\ Reset value: 0x00000000
\

$000003ff constant DCMIPP_DCMIPP_P2DSCR_HDIV                        \ Horizontal division factor, from 128 (8x) to 1023 (1x)
$03ff0000 constant DCMIPP_DCMIPP_P2DSCR_VDIV                        \ Vertical division factor, from 128 (8x) to 1023 (1x)
$80000000 constant DCMIPP_DCMIPP_P2DSCR_ENABLE                      \ None


\
\ @brief DCMIPP Pipex downsize ratio register
\ Address offset: 0xD14
\ Reset value: 0x00000000
\

$0000ffff constant DCMIPP_DCMIPP_P2DSRTIOR_HRATIO                   \ Horizontal ratio, from 8192 (1x) to 65535 (8x)
$ffff0000 constant DCMIPP_DCMIPP_P2DSRTIOR_VRATIO                   \ Vertical ratio, from 8192 (1x) to 65535 (8x)


\
\ @brief DCMIPP Pipex downsize destination size register
\ Address offset: 0xD18
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2DSSZR_HSIZE                      \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2DSSZR_VSIZE                      \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipex common ROI configuration register
\ Address offset: 0xD20
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P2CMRICR_ROILSZ                    \ Region of interest line size width
$00010000 constant DCMIPP_DCMIPP_P2CMRICR_ROI1EN                    \ Region of interest 1 enable
$00020000 constant DCMIPP_DCMIPP_P2CMRICR_ROI2EN                    \ Region of interest 2 enable
$00040000 constant DCMIPP_DCMIPP_P2CMRICR_ROI3EN                    \ Region of interest 3 enable
$00080000 constant DCMIPP_DCMIPP_P2CMRICR_ROI4EN                    \ Region of interest 4 enable
$00100000 constant DCMIPP_DCMIPP_P2CMRICR_ROI5EN                    \ Region of interest 5 enable
$00200000 constant DCMIPP_DCMIPP_P2CMRICR_ROI6EN                    \ Region of interest 6 enable
$00400000 constant DCMIPP_DCMIPP_P2CMRICR_ROI7EN                    \ Region of interest 7 enable
$00800000 constant DCMIPP_DCMIPP_P2CMRICR_ROI8EN                    \ Region of interest 8 enable


\
\ @brief DCMIPP Pipe2 ROI1 configuration register 1
\ Address offset: 0xD24
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI1CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2RI1CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P2RI1CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P2RI1CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2RI1CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe2 ROI1 configuration register 2
\ Address offset: 0xD28
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI1CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2RI1CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 ROI2 configuration register 1
\ Address offset: 0xD2C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI2CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2RI2CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P2RI2CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P2RI2CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2RI2CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe2 ROI2 configuration register 2
\ Address offset: 0xD30
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI2CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2RI2CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 ROI3 configuration register 1
\ Address offset: 0xD34
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI3CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2RI3CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P2RI3CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P2RI3CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2RI3CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe2 ROI3 configuration register 2
\ Address offset: 0xD38
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI3CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2RI3CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 ROI4 configuration register 1
\ Address offset: 0xD3C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI4CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2RI4CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P2RI4CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P2RI4CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2RI4CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe2 ROI4 configuration register 2
\ Address offset: 0xD40
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI4CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2RI4CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 ROI5 configuration register 1
\ Address offset: 0xD44
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI5CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2RI5CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P2RI5CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P2RI5CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2RI5CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe2 ROI5 configuration register 2
\ Address offset: 0xD48
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI5CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2RI5CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 ROI6 configuration register 1
\ Address offset: 0xD4C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI6CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2RI6CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P2RI6CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P2RI6CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2RI6CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe2 ROI6 configuration register 2
\ Address offset: 0xD50
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI6CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2RI6CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 ROI7 configuration register 1
\ Address offset: 0xD54
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI7CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2RI7CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P2RI7CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P2RI7CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2RI7CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe2 ROI7 configuration register 2
\ Address offset: 0xD58
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI7CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2RI7CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 ROI8 configuration register 1
\ Address offset: 0xD5C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI8CR1_HSTART                    \ Horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2RI8CR1_CLB                       \ Color line blue
$0000c000 constant DCMIPP_DCMIPP_P2RI8CR1_CLG                       \ Color line green
$0fff0000 constant DCMIPP_DCMIPP_P2RI8CR1_VSTART                    \ Vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2RI8CR1_CLR                       \ Color line red


\
\ @brief DCMIPP Pipe2 ROI8 configuration register 2
\ Address offset: 0xD60
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2RI8CR2_HSIZE                     \ Horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2RI8CR2_VSIZE                     \ Vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipex gamma configuration register
\ Address offset: 0xD70
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P2GMCR_ENABLE                      \ None


\
\ @brief DCMIPP Pipe2 pixel packer configuration register
\ Address offset: 0xDC0
\ Reset value: 0x00000000
\

$0000000f constant DCMIPP_DCMIPP_P2PPCR_FORMAT                      \ Memory format (only coplanar formats are supported in Pipe2)
$00000010 constant DCMIPP_DCMIPP_P2PPCR_SWAPRB                      \ Swaps R-vs-B components if RGB, and if YUV, swaps U-vs-V components
$0000e000 constant DCMIPP_DCMIPP_P2PPCR_LINEMULT                    \ Amount of capture completed lines for LINE event and interrupt
$00010000 constant DCMIPP_DCMIPP_P2PPCR_DBM                         \ Double buffer mode
$000e0000 constant DCMIPP_DCMIPP_P2PPCR_LMAWM                       \ Line multi address wrapping modulo
$00100000 constant DCMIPP_DCMIPP_P2PPCR_LMAWE                       \ Line multi address wrapping enable bit


\
\ @brief DCMIPP Pipe2 pixel packer Memory0 address register 1
\ Address offset: 0xDC4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P2PPM0AR1_M0A                      \ Memory0 address


\
\ @brief DCMIPP Pipe2 pixel packer Memory0 address register 2
\ Address offset: 0xDC8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P2PPM0AR2_M0A                      \ Memory0 address


\
\ @brief DCMIPP Pipex pixel packer Memory0 pitch register
\ Address offset: 0xDCC
\ Reset value: 0x00000000
\

$00007fff constant DCMIPP_DCMIPP_P2PPM0PR_PITCH                     \ Number of bytes between the address of two consecutive lines.


\
\ @brief DCMIPP Pipex status Memory0 address register
\ Address offset: 0xDD0
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P2STM0AR_M0A                       \ Memory0 address


\
\ @brief DCMIPP Pipe2 interrupt enable register
\ Address offset: 0xDF4
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P2IER_LINEIE                       \ Multi-line capture completed interrupt enable
$00000002 constant DCMIPP_DCMIPP_P2IER_FRAMEIE                      \ Frame capture completed interrupt enable
$00000004 constant DCMIPP_DCMIPP_P2IER_VSYNCIE                      \ VSYNC interrupt enable
$00000080 constant DCMIPP_DCMIPP_P2IER_OVRIE                        \ Overrun interrupt enable


\
\ @brief DCMIPP Pipe2 status register
\ Address offset: 0xDF8
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P2SR_LINEF                         \ Multi-line capture completed raw interrupt status
$00000002 constant DCMIPP_DCMIPP_P2SR_FRAMEF                        \ Frame capture completed raw interrupt status
$00000004 constant DCMIPP_DCMIPP_P2SR_VSYNCF                        \ VSYNC raw interrupt status
$00000080 constant DCMIPP_DCMIPP_P2SR_OVRF                          \ Overrun raw interrupt status
$00010000 constant DCMIPP_DCMIPP_P2SR_LSTLINE                       \ Last line LSB bit, sampled at frame capture complete event.
$00020000 constant DCMIPP_DCMIPP_P2SR_LSTFRM                        \ Last frame LSB bit, sampled at frame capture complete event. The information is extracted from the frame data number which can be delivered by the camera through the CSI2 interface.
$00800000 constant DCMIPP_DCMIPP_P2SR_CPTACT                        \ Capture immediate status


\
\ @brief DCMIPP Pipe2 interrupt clear register
\ Address offset: 0xDFC
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P2FCR_CLINEF                       \ Multi-line capture complete interrupt status clear
$00000002 constant DCMIPP_DCMIPP_P2FCR_CFRAMEF                      \ Frame capture complete interrupt status clear
$00000004 constant DCMIPP_DCMIPP_P2FCR_CVSYNCF                      \ Vertical synchronization interrupt status clear
$00000080 constant DCMIPP_DCMIPP_P2FCR_COVRF                        \ Overrun interrupt status clear


\
\ @brief DCMIPP Pipe2 current flow selection configuration register
\ Address offset: 0xE04
\ Reset value: 0x00000000
\

$0000003f constant DCMIPP_DCMIPP_P2CFSCR_DTIDA                      \ Current data type ID
$00180000 constant DCMIPP_DCMIPP_P2CFSCR_VC                         \ Current flow selection mode
$3f000000 constant DCMIPP_DCMIPP_P2CFSCR_FDTF                       \ Current force data type format
$40000000 constant DCMIPP_DCMIPP_P2CFSCR_FDTFEN                     \ Current force data type format enable
$80000000 constant DCMIPP_DCMIPP_P2CFSCR_PIPEN                      \ Current activation of PipeN


\
\ @brief DCMIPP Pipex current flow control configuration register
\ Address offset: 0xF00
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P2CFCTCR_FRATE                     \ Frame capture rate control
$00000004 constant DCMIPP_DCMIPP_P2CFCTCR_CPTMODE                   \ Capture mode
$00000008 constant DCMIPP_DCMIPP_P2CFCTCR_CPTREQ                    \ Capture requested


\
\ @brief DCMIPP Pipex current crop window start register
\ Address offset: 0xF04
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CCRSTR_HSTART                    \ Current horizontal start, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CCRSTR_VSTART                    \ Current vertical start, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipex current crop window size register
\ Address offset: 0xF08
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CCRSZR_HSIZE                     \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CCRSZR_VSIZE                     \ Current vertical size, from 0 to 4094 pixels high
$80000000 constant DCMIPP_DCMIPP_P2CCRSZR_ENABLE                    \ Current ENABLE bit value.


\
\ @brief DCMIPP Pipex current decimation register
\ Address offset: 0xF0C
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P2CDCCR_ENABLE                     \ None
$00000006 constant DCMIPP_DCMIPP_P2CDCCR_HDEC                       \ Horizontal decimation ratio
$00000018 constant DCMIPP_DCMIPP_P2CDCCR_VDEC                       \ Vertical decimation ratio


\
\ @brief DCMIPP Pipex current downsize configuration register
\ Address offset: 0xF10
\ Reset value: 0x00000000
\

$000003ff constant DCMIPP_DCMIPP_P2CDSCR_HDIV                       \ Current horizontal division factor, from 128 (8x) to 1023 (1x)
$03ff0000 constant DCMIPP_DCMIPP_P2CDSCR_VDIV                       \ Current vertical division factor, from 128 (8x) to 1023 (1x)
$80000000 constant DCMIPP_DCMIPP_P2CDSCR_ENABLE                     \ Current value of bit ENABLE


\
\ @brief DCMIPP Pipex current downsize ratio register
\ Address offset: 0xF14
\ Reset value: 0x00000000
\

$0000ffff constant DCMIPP_DCMIPP_P2CDSRTIOR_HRATIO                  \ Current horizontal ratio, from 8192 (1x) to 65535 (8x)
$ffff0000 constant DCMIPP_DCMIPP_P2CDSRTIOR_VRATIO                  \ Current vertical ratio, from 8192 (1x) to 65535 (8x)


\
\ @brief DCMIPP Pipex current downsize destination size register
\ Address offset: 0xF18
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CDSSZR_HSIZE                     \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CDSSZR_VSIZE                     \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipex current common ROI configuration register
\ Address offset: 0xF20
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P2CCMRICR_ROILSZ                   \ Current region of interest line size width
$00010000 constant DCMIPP_DCMIPP_P2CCMRICR_ROI1EN                   \ Current region of interest 1 enable
$00020000 constant DCMIPP_DCMIPP_P2CCMRICR_ROI2EN                   \ Current region of interest 2 enable
$00040000 constant DCMIPP_DCMIPP_P2CCMRICR_ROI3EN                   \ Current region of interest 3 enable
$00080000 constant DCMIPP_DCMIPP_P2CCMRICR_ROI4EN                   \ Current region of interest 4 enable
$00100000 constant DCMIPP_DCMIPP_P2CCMRICR_ROI5EN                   \ Current region of interest 5 enable
$00200000 constant DCMIPP_DCMIPP_P2CCMRICR_ROI6EN                   \ Current region of interest 6 enable
$00400000 constant DCMIPP_DCMIPP_P2CCMRICR_ROI7EN                   \ Current region of interest 7 enable
$00800000 constant DCMIPP_DCMIPP_P2CCMRICR_ROI8EN                   \ Current region of interest 8 enable


\
\ @brief DCMIPP Pipe2 current ROI1 configuration register 1
\ Address offset: 0xF24
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI1CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2CRI1CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P2CRI1CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P2CRI1CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2CRI1CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe2 current ROI1 configuration register 2
\ Address offset: 0xF28
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI1CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CRI1CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 current ROI2 configuration register 1
\ Address offset: 0xF2C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI2CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2CRI2CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P2CRI2CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P2CRI2CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2CRI2CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe2 current ROI2 configuration register 2
\ Address offset: 0xF30
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI2CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CRI2CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 current ROI3 configuration register 1
\ Address offset: 0xF34
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI3CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2CRI3CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P2CRI3CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P2CRI3CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2CRI3CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe2 current ROI3 configuration register 2
\ Address offset: 0xF38
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI3CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CRI3CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 current ROI4 configuration register 1
\ Address offset: 0xF3C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI4CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2CRI4CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P2CRI4CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P2CRI4CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2CRI4CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe2 current ROI4 configuration register 2
\ Address offset: 0xF40
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI4CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CRI4CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 current ROI5 configuration register 1
\ Address offset: 0xF44
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI5CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2CRI5CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P2CRI5CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P2CRI5CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2CRI5CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe2 current ROI5 configuration register 2
\ Address offset: 0xF48
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI5CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CRI5CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 current ROI6 configuration register 1
\ Address offset: 0xF4C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI6CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2CRI6CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P2CRI6CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P2CRI6CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2CRI6CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe2 current ROI6 configuration register 2
\ Address offset: 0xF50
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI6CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CRI6CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 current ROI7 configuration register 1
\ Address offset: 0xF54
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI7CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2CRI7CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P2CRI7CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P2CRI7CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2CRI7CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe2 current ROI7 configuration register 2
\ Address offset: 0xF58
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI7CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CRI7CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 current ROI8 configuration register 1
\ Address offset: 0xF5C
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI8CR1_HSTART                   \ Current horizontal start, from 0 to 4094 pixels wide
$00003000 constant DCMIPP_DCMIPP_P2CRI8CR1_CLB                      \ Current color line blue
$0000c000 constant DCMIPP_DCMIPP_P2CRI8CR1_CLG                      \ Current color line green
$0fff0000 constant DCMIPP_DCMIPP_P2CRI8CR1_VSTART                   \ Current vertical start, from 0 to 4094 pixels high
$30000000 constant DCMIPP_DCMIPP_P2CRI8CR1_CLR                      \ Current color line red


\
\ @brief DCMIPP Pipe2 current ROI8 configuration register 2
\ Address offset: 0xF60
\ Reset value: 0x00000000
\

$00000fff constant DCMIPP_DCMIPP_P2CRI8CR2_HSIZE                    \ Current horizontal size, from 0 to 4094 pixels wide
$0fff0000 constant DCMIPP_DCMIPP_P2CRI8CR2_VSIZE                    \ Current vertical size, from 0 to 4094 pixels high


\
\ @brief DCMIPP Pipe2 current pixel packer configuration register
\ Address offset: 0xFC0
\ Reset value: 0x00000000
\

$0000000f constant DCMIPP_DCMIPP_P2CPPCR_FORMAT                     \ Memory format (only coplanar formats are supported in Pipe2)
$00000010 constant DCMIPP_DCMIPP_P2CPPCR_SWAPRB                     \ Swaps R-vs-B components if RGB, and if YUV, swaps U-vs-V components
$0000e000 constant DCMIPP_DCMIPP_P2CPPCR_LINEMULT                   \ Amount of capture completed lines for LINE event and interrupt
$00010000 constant DCMIPP_DCMIPP_P2CPPCR_DBM                        \ Double buffer mode
$000e0000 constant DCMIPP_DCMIPP_P2CPPCR_LMAWM                      \ Line multi address wrapping modulo
$00100000 constant DCMIPP_DCMIPP_P2CPPCR_LMAWE                      \ Line multi address wrapping enable bit


\
\ @brief DCMIPP Pipe2 current pixel packer Memory0 address register 1
\ Address offset: 0xFC4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P2CPPM0AR1_M0A                     \ Memory0 address


\
\ @brief DCMIPP Pipe2 current pixel packer Memory0 address register 2
\ Address offset: 0xFC8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P2CPPM0AR2_M0A                     \ Memory0 address


\
\ @brief Digital camera interface pixel pipeline
\
$48002000 constant DCMIPP_DCMIPP_IPGR1  \ offset: 0x00 : DCMIPP IPPLUG global register 1
$48002004 constant DCMIPP_DCMIPP_IPGR2  \ offset: 0x04 : DCMIPP IPPLUG global register 2
$48002008 constant DCMIPP_DCMIPP_IPGR3  \ offset: 0x08 : DCMIPP IPPLUG global register 3
$4800201c constant DCMIPP_DCMIPP_IPGR8  \ offset: 0x1C : DCMIPP IPPLUG identification register
$48002020 constant DCMIPP_DCMIPP_IPC1R1  \ offset: 0x20 : DCMIPP IPPLUG Clientx register 1
$48002024 constant DCMIPP_DCMIPP_IPC1R2  \ offset: 0x24 : DCMIPP IPPLUG Clientx register 2
$48002028 constant DCMIPP_DCMIPP_IPC1R3  \ offset: 0x28 : DCMIPP IPPLUG Clientx register 3
$48002030 constant DCMIPP_DCMIPP_IPC2R1  \ offset: 0x30 : DCMIPP IPPLUG Clientx register 1
$48002034 constant DCMIPP_DCMIPP_IPC2R2  \ offset: 0x34 : DCMIPP IPPLUG Clientx register 2
$48002038 constant DCMIPP_DCMIPP_IPC2R3  \ offset: 0x38 : DCMIPP IPPLUG Clientx register 3
$48002040 constant DCMIPP_DCMIPP_IPC3R1  \ offset: 0x40 : DCMIPP IPPLUG Clientx register 1
$48002044 constant DCMIPP_DCMIPP_IPC3R2  \ offset: 0x44 : DCMIPP IPPLUG Clientx register 2
$48002048 constant DCMIPP_DCMIPP_IPC3R3  \ offset: 0x48 : DCMIPP IPPLUG Clientx register 3
$48002050 constant DCMIPP_DCMIPP_IPC4R1  \ offset: 0x50 : DCMIPP IPPLUG Clientx register 1
$48002054 constant DCMIPP_DCMIPP_IPC4R2  \ offset: 0x54 : DCMIPP IPPLUG Clientx register 2
$48002058 constant DCMIPP_DCMIPP_IPC4R3  \ offset: 0x58 : DCMIPP IPPLUG Clientx register 3
$48002060 constant DCMIPP_DCMIPP_IPC5R1  \ offset: 0x60 : DCMIPP IPPLUG Clientx register 1
$48002064 constant DCMIPP_DCMIPP_IPC5R2  \ offset: 0x64 : DCMIPP IPPLUG Clientx register 2
$48002068 constant DCMIPP_DCMIPP_IPC5R3  \ offset: 0x68 : DCMIPP IPPLUG Clientx register 3
$48002104 constant DCMIPP_DCMIPP_PRCR  \ offset: 0x104 : DCMIPP parallel interface control register
$48002108 constant DCMIPP_DCMIPP_PRESCR  \ offset: 0x108 : DCMIPP parallel interface embedded synchronization code register
$4800210c constant DCMIPP_DCMIPP_PRESUR  \ offset: 0x10C : DCMIPP parallel interface embedded synchronization unmask register
$480021f4 constant DCMIPP_DCMIPP_PRIER  \ offset: 0x1F4 : DCMIPP parallel interface interrupt enable register
$480021f8 constant DCMIPP_DCMIPP_PRSR  \ offset: 0x1F8 : DCMIPP parallel interface status register
$480021fc constant DCMIPP_DCMIPP_PRFCR  \ offset: 0x1FC : DCMIPP parallel interface interrupt clear register
$48002204 constant DCMIPP_DCMIPP_CMCR  \ offset: 0x204 : DCMIPP common configuration register
$48002208 constant DCMIPP_DCMIPP_CMFRCR  \ offset: 0x208 : DCMIPP common frame counter register
$480023f0 constant DCMIPP_DCMIPP_CMIER  \ offset: 0x3F0 : DCMIPP common interrupt enable register
$480023f4 constant DCMIPP_DCMIPP_CMSR1  \ offset: 0x3F4 : DCMIPP common status register 1
$480023f8 constant DCMIPP_DCMIPP_CMSR2  \ offset: 0x3F8 : DCMIPP common status register 2
$480023fc constant DCMIPP_DCMIPP_CMFCR  \ offset: 0x3FC : DCMIPP common interrupt clear register
$48002404 constant DCMIPP_DCMIPP_P0FSCR  \ offset: 0x404 : DCMIPP Pipe0 flow selection configuration register
$48002500 constant DCMIPP_DCMIPP_P0FCTCR  \ offset: 0x500 : DCMIPP Pipe0 flow control configuration register
$48002504 constant DCMIPP_DCMIPP_P0SCSTR  \ offset: 0x504 : DCMIPP Pipe0 stat/crop start register
$48002508 constant DCMIPP_DCMIPP_P0SCSZR  \ offset: 0x508 : DCMIPP Pipe0 stat/crop size register
$480025b0 constant DCMIPP_DCMIPP_P0DCCNTR  \ offset: 0x5B0 : DCMIPP Pipe0 dump counter register
$480025b4 constant DCMIPP_DCMIPP_P0DCLMTR  \ offset: 0x5B4 : DCMIPP Pipe0 dump limit register
$480025c0 constant DCMIPP_DCMIPP_P0PPCR  \ offset: 0x5C0 : DCMIPP Pipe0 pixel packer configuration register
$480025c4 constant DCMIPP_DCMIPP_P0PPM0AR1  \ offset: 0x5C4 : DCMIPP Pipe0 pixel packer Memory0 address register 1
$480025c8 constant DCMIPP_DCMIPP_P0PPM0AR2  \ offset: 0x5C8 : DCMIPP Pipe0 pixel packer Memory0 address register 2
$480025d0 constant DCMIPP_DCMIPP_P0STM0AR  \ offset: 0x5D0 : DCMIPP Pipe0 status Memory0 address register
$480025f4 constant DCMIPP_DCMIPP_P0IER  \ offset: 0x5F4 : DCMIPP Pipe0 interrupt enable register
$480025f8 constant DCMIPP_DCMIPP_P0SR  \ offset: 0x5F8 : DCMIPP Pipe0 status register
$480025fc constant DCMIPP_DCMIPP_P0FCR  \ offset: 0x5FC : DCMIPP Pipe0 interrupt clear register
$48002604 constant DCMIPP_DCMIPP_P0CFSCR  \ offset: 0x604 : DCMIPP Pipe0 current flow selection configuration register
$48002700 constant DCMIPP_DCMIPP_P0CFCTCR  \ offset: 0x700 : DCMIPP Pipe0 current flow control configuration register
$48002704 constant DCMIPP_DCMIPP_P0CSCSTR  \ offset: 0x704 : DCMIPP Pipe0 current stat/crop start register
$48002708 constant DCMIPP_DCMIPP_P0CSCSZR  \ offset: 0x708 : DCMIPP Pipe0 current stat/crop size register
$480027c0 constant DCMIPP_DCMIPP_P0CPPCR  \ offset: 0x7C0 : DCMIPP Pipe0 current pixel packer configuration register
$480027c4 constant DCMIPP_DCMIPP_P0CPPM0AR1  \ offset: 0x7C4 : DCMIPP Pipe0 current pixel packer Memory0 address register 1
$480027c8 constant DCMIPP_DCMIPP_P0CPPM0AR2  \ offset: 0x7C8 : DCMIPP Pipe0 current pixel packer Memory0 address register 2
$48002804 constant DCMIPP_DCMIPP_P1FSCR  \ offset: 0x804 : DCMIPP Pipe1 flow selection configuration register
$48002820 constant DCMIPP_DCMIPP_P1SRCR  \ offset: 0x820 : DCMIPP Pipe1 stat removal configuration register
$48002824 constant DCMIPP_DCMIPP_P1BPRCR  \ offset: 0x824 : DCMIPP Pipe1 bad pixel removal control register
$48002828 constant DCMIPP_DCMIPP_P1BPRSR  \ offset: 0x828 : DCMIPP Pipe1 bad pixel removal status register
$48002830 constant DCMIPP_DCMIPP_P1DECR  \ offset: 0x830 : DCMIPP Pipe1 decimation register
$48002840 constant DCMIPP_DCMIPP_P1BLCCR  \ offset: 0x840 : DCMIPP Pipe1 black level calibration control register
$48002844 constant DCMIPP_DCMIPP_P1EXCR1  \ offset: 0x844 : DCMIPP Pipe1 exposure control register 1
$48002848 constant DCMIPP_DCMIPP_P1EXCR2  \ offset: 0x848 : DCMIPP Pipe1 exposure control register 2
$48002850 constant DCMIPP_DCMIPP_P1ST1CR  \ offset: 0x850 : DCMIPP Pipe1 statistics1 control register
$48002854 constant DCMIPP_DCMIPP_P1ST2CR  \ offset: 0x854 : DCMIPP Pipe1 statistics 2 control register
$48002858 constant DCMIPP_DCMIPP_P1ST3CR  \ offset: 0x858 : DCMIPP Pipe1 statistics 3 control register
$4800285c constant DCMIPP_DCMIPP_P1STSTR  \ offset: 0x85C : DCMIPP Pipe1 statistics window start register
$48002860 constant DCMIPP_DCMIPP_P1STSZR  \ offset: 0x860 : DCMIPP Pipe1 statistics window size register
$48002864 constant DCMIPP_DCMIPP_P1ST1SR  \ offset: 0x864 : DCMIPP Pipe1 statistics 1 status register
$48002868 constant DCMIPP_DCMIPP_P1ST2SR  \ offset: 0x868 : DCMIPP Pipe1 statistics 2 status register
$4800286c constant DCMIPP_DCMIPP_P1ST3SR  \ offset: 0x86C : DCMIPP Pipe1 statistics 3 status register
$48002870 constant DCMIPP_DCMIPP_P1DMCR  \ offset: 0x870 : DCMIPP Pipe1 demosaicing configuration register
$48002880 constant DCMIPP_DCMIPP_P1CCCR  \ offset: 0x880 : DCMIPP Pipe1 ColorConv configuration register
$48002884 constant DCMIPP_DCMIPP_P1CCRR1  \ offset: 0x884 : DCMIPP Pipe1 ColorConv red coefficient register 1
$48002888 constant DCMIPP_DCMIPP_P1CCRR2  \ offset: 0x888 : DCMIPP Pipe1 ColorConv red coefficient register 2
$4800288c constant DCMIPP_DCMIPP_P1CCGR1  \ offset: 0x88C : DCMIPP Pipe1 ColorConv green coefficient register 1
$48002890 constant DCMIPP_DCMIPP_P1CCGR2  \ offset: 0x890 : DCMIPP Pipe1 ColorConv green coefficient register 2
$48002894 constant DCMIPP_DCMIPP_P1CCBR1  \ offset: 0x894 : DCMIPP Pipex ColorConv blue coefficient register 1
$48002898 constant DCMIPP_DCMIPP_P1CCBR2  \ offset: 0x898 : DCMIPP Pipe1 ColorConv blue coefficient register 2
$480028a0 constant DCMIPP_DCMIPP_P1CTCR1  \ offset: 0x8A0 : DCMIPP Pipe1 contrast control register 1
$480028a4 constant DCMIPP_DCMIPP_P1CTCR2  \ offset: 0x8A4 : DCMIPP Pipe1 contrast control register 2
$480028a8 constant DCMIPP_DCMIPP_P1CTCR3  \ offset: 0x8A8 : DCMIPP Pipe1 contrast control register 3
$48002900 constant DCMIPP_DCMIPP_P1FCTCR  \ offset: 0x900 : DCMIPP Pipex flow control configuration register
$48002904 constant DCMIPP_DCMIPP_P1CRSTR  \ offset: 0x904 : DCMIPP Pipex crop window start register
$48002908 constant DCMIPP_DCMIPP_P1CRSZR  \ offset: 0x908 : DCMIPP Pipex crop window size register
$4800290c constant DCMIPP_DCMIPP_P1DCCR  \ offset: 0x90C : DCMIPP Pipex decimation register
$48002910 constant DCMIPP_DCMIPP_P1DSCR  \ offset: 0x910 : DCMIPP Pipex downsize configuration register
$48002914 constant DCMIPP_DCMIPP_P1DSRTIOR  \ offset: 0x914 : DCMIPP Pipex downsize ratio register
$48002918 constant DCMIPP_DCMIPP_P1DSSZR  \ offset: 0x918 : DCMIPP Pipex downsize destination size register
$48002920 constant DCMIPP_DCMIPP_P1CMRICR  \ offset: 0x920 : DCMIPP Pipex common ROI configuration register
$48002924 constant DCMIPP_DCMIPP_P1RI1CR1  \ offset: 0x924 : DCMIPP Pipe1 ROI1 configuration register 1
$48002928 constant DCMIPP_DCMIPP_P1RI1CR2  \ offset: 0x928 : DCMIPP Pipe1 ROI1 configuration register 2
$4800292c constant DCMIPP_DCMIPP_P1RI2CR1  \ offset: 0x92C : DCMIPP Pipe1 ROI2 configuration register 1
$48002930 constant DCMIPP_DCMIPP_P1RI2CR2  \ offset: 0x930 : DCMIPP Pipe1 ROI2 configuration register 2
$48002934 constant DCMIPP_DCMIPP_P1RI3CR1  \ offset: 0x934 : DCMIPP Pipe1 ROI3 configuration register 1
$48002938 constant DCMIPP_DCMIPP_P1RI3CR2  \ offset: 0x938 : DCMIPP Pipe1 ROI3 configuration register 2
$4800293c constant DCMIPP_DCMIPP_P1RI4CR1  \ offset: 0x93C : DCMIPP Pipe1 ROI4 configuration register 1
$48002940 constant DCMIPP_DCMIPP_P1RI4CR2  \ offset: 0x940 : DCMIPP Pipe1 ROI4 configuration register 2
$48002944 constant DCMIPP_DCMIPP_P1RI5CR1  \ offset: 0x944 : DCMIPP Pipe1 ROI5 configuration register 1
$48002948 constant DCMIPP_DCMIPP_P1RI5CR2  \ offset: 0x948 : DCMIPP Pipe1 ROI5 configuration register 2
$4800294c constant DCMIPP_DCMIPP_P1RI6CR1  \ offset: 0x94C : DCMIPP Pipe1 ROI6 configuration register 1
$48002950 constant DCMIPP_DCMIPP_P1RI6CR2  \ offset: 0x950 : DCMIPP Pipe1 ROI6 configuration register 2
$48002954 constant DCMIPP_DCMIPP_P1RI7CR1  \ offset: 0x954 : DCMIPP Pipe1 ROI7 configuration register 1
$48002958 constant DCMIPP_DCMIPP_P1RI7CR2  \ offset: 0x958 : DCMIPP Pipe1 ROI7 configuration register 2
$4800295c constant DCMIPP_DCMIPP_P1RI8CR1  \ offset: 0x95C : DCMIPP Pipe1 ROI8 configuration register 1
$48002960 constant DCMIPP_DCMIPP_P1RI8CR2  \ offset: 0x960 : DCMIPP Pipe1 ROI8 configuration register 2
$48002970 constant DCMIPP_DCMIPP_P1GMCR  \ offset: 0x970 : DCMIPP Pipex gamma configuration register
$48002980 constant DCMIPP_DCMIPP_P1YUVCR  \ offset: 0x980 : DCMIPP Pipe1 YUVConv configuration register
$48002984 constant DCMIPP_DCMIPP_P1YUVRR1  \ offset: 0x984 : DCMIPP Pipe1 YUVConv red coefficient register 1
$48002988 constant DCMIPP_DCMIPP_P1YUVRR2  \ offset: 0x988 : DCMIPP Pipe1 YUVConv red coefficient register 2
$4800298c constant DCMIPP_DCMIPP_P1YUVGR1  \ offset: 0x98C : DCMIPP Pipe1 YUVConv green coefficient register 1
$48002990 constant DCMIPP_DCMIPP_P1YUVGR2  \ offset: 0x990 : DCMIPP Pipe1 YUVConv green coefficient register 2
$48002994 constant DCMIPP_DCMIPP_P1YUVBR1  \ offset: 0x994 : DCMIPP Pipe1 YUVConv blue coefficient register 1
$48002998 constant DCMIPP_DCMIPP_P1YUVBR2  \ offset: 0x998 : DCMIPP Pipe1 YUV blue coefficient register 2
$480029c0 constant DCMIPP_DCMIPP_P1PPCR  \ offset: 0x9C0 : DCMIPP Pipe1 pixel packer configuration register
$480029c4 constant DCMIPP_DCMIPP_P1PPM0AR1  \ offset: 0x9C4 : DCMIPP Pipe1 pixel packer Memory0 address register 1
$480029c8 constant DCMIPP_DCMIPP_P1PPM0AR2  \ offset: 0x9C8 : DCMIPP Pipe1 pixel packer Memory0 address register 2
$480029cc constant DCMIPP_DCMIPP_P1PPM0PR  \ offset: 0x9CC : DCMIPP Pipex pixel packer Memory0 pitch register
$480029d0 constant DCMIPP_DCMIPP_P1STM0AR  \ offset: 0x9D0 : DCMIPP Pipex status Memory0 address register
$480029d4 constant DCMIPP_DCMIPP_P1PPM1AR1  \ offset: 0x9D4 : DCMIPP Pipex pixel packer Memory1 address register 1
$480029d8 constant DCMIPP_DCMIPP_P1PPM1AR2  \ offset: 0x9D8 : DCMIPP Pipex pixel packer Memory1 address register 2
$480029dc constant DCMIPP_DCMIPP_P1PPM1PR  \ offset: 0x9DC : DCMIPP Pipex pixel packer Memory1 pitch register
$480029e0 constant DCMIPP_DCMIPP_P1STM1AR  \ offset: 0x9E0 : DCMIPP Pipex status Memory1 address register
$480029e4 constant DCMIPP_DCMIPP_P1PPM2AR1  \ offset: 0x9E4 : DCMIPP Pipex pixel packer memory2 address register 1
$480029e8 constant DCMIPP_DCMIPP_P1PPM2AR2  \ offset: 0x9E8 : DCMIPP Pipex pixel packer memory2 address register 2
$480029f0 constant DCMIPP_DCMIPP_P1STM2AR  \ offset: 0x9F0 : DCMIPP Pipex status Memory2 address register
$480029f4 constant DCMIPP_DCMIPP_P1IER  \ offset: 0x9F4 : DCMIPP Pipe1 interrupt enable register
$480029f8 constant DCMIPP_DCMIPP_P1SR  \ offset: 0x9F8 : DCMIPP Pipe1 status register
$480029fc constant DCMIPP_DCMIPP_P1FCR  \ offset: 0x9FC : DCMIPP Pipe1 interrupt clear register
$48002a04 constant DCMIPP_DCMIPP_P1CFSCR  \ offset: 0xA04 : DCMIPP Pipe1 current flow selection configuration register
$48002a24 constant DCMIPP_DCMIPP_P1CBPRCR  \ offset: 0xA24 : DCMIPP Pipe1 current bad pixel removal register
$48002a40 constant DCMIPP_DCMIPP_P1CBLCCR  \ offset: 0xA40 : DCMIPP Pipe1 current black level calibration control register
$48002a44 constant DCMIPP_DCMIPP_P1CEXCR1  \ offset: 0xA44 : DCMIPP Pipe1 current exposure control register 1
$48002a48 constant DCMIPP_DCMIPP_P1CEXCR2  \ offset: 0xA48 : DCMIPP Pipe1 current exposure control register 2
$48002a50 constant DCMIPP_DCMIPP_P1CST1CR  \ offset: 0xA50 : DCMIPP Pipe1 current statistics 1 control register
$48002a54 constant DCMIPP_DCMIPP_P1CST2CR  \ offset: 0xA54 : DCMIPP Pipe1 current statistics 2 control register
$48002a58 constant DCMIPP_DCMIPP_P1CST3CR  \ offset: 0xA58 : DCMIPP Pipe1 current statistics 3 control register
$48002a5c constant DCMIPP_DCMIPP_P1CSTSTR  \ offset: 0xA5C : DCMIPP Pipe1 current statistics window start register
$48002a60 constant DCMIPP_DCMIPP_P1CSTSZR  \ offset: 0xA60 : DCMIPP Pipe1 current statistics window size register
$48002a80 constant DCMIPP_DCMIPP_P1CCCCR  \ offset: 0xA80 : DCMIPP Pipe1 current ColorConv configuration register
$48002a84 constant DCMIPP_DCMIPP_P1CCCRR1  \ offset: 0xA84 : DCMIPP Pipe1 current ColorConv red coefficient register 1
$48002a88 constant DCMIPP_DCMIPP_P1CCCRR2  \ offset: 0xA88 : DCMIPP Pipe1 current ColorConv red coefficient register 2
$48002a8c constant DCMIPP_DCMIPP_P1CCCGR1  \ offset: 0xA8C : DCMIPP Pipe1 current ColorConv green coefficient register 1
$48002a90 constant DCMIPP_DCMIPP_P1CCCGR2  \ offset: 0xA90 : DCMIPP Pipe1 current ColorConv green coefficient register 2
$48002a94 constant DCMIPP_DCMIPP_P1CCCBR1  \ offset: 0xA94 : DCMIPP Pipex current ColorConv blue coefficient register 1
$48002a98 constant DCMIPP_DCMIPP_P1CCCBR2  \ offset: 0xA98 : DCMIPP Pipe1 current ColorConv blue coefficient register 2
$48002aa0 constant DCMIPP_DCMIPP_P1CCTCR1  \ offset: 0xAA0 : DCMIPP Pipe1 current contrast control register 1
$48002aa4 constant DCMIPP_DCMIPP_P1CCTCR2  \ offset: 0xAA4 : DCMIPP Pipe1 current contrast control register 2
$48002aa8 constant DCMIPP_DCMIPP_P1CCTCR3  \ offset: 0xAA8 : DCMIPP Pipe1 current contrast control register 3
$48002b00 constant DCMIPP_DCMIPP_P1CFCTCR  \ offset: 0xB00 : DCMIPP Pipex current flow control configuration register
$48002b04 constant DCMIPP_DCMIPP_P1CCRSTR  \ offset: 0xB04 : DCMIPP Pipex current crop window start register
$48002b08 constant DCMIPP_DCMIPP_P1CCRSZR  \ offset: 0xB08 : DCMIPP Pipex current crop window size register
$48002b0c constant DCMIPP_DCMIPP_P1CDCCR  \ offset: 0xB0C : DCMIPP Pipex current decimation register
$48002b10 constant DCMIPP_DCMIPP_P1CDSCR  \ offset: 0xB10 : DCMIPP Pipex current downsize configuration register
$48002b14 constant DCMIPP_DCMIPP_P1CDSRTIOR  \ offset: 0xB14 : DCMIPP Pipex current downsize ratio register
$48002b18 constant DCMIPP_DCMIPP_P1CDSSZR  \ offset: 0xB18 : DCMIPP Pipex current downsize destination size register
$48002b20 constant DCMIPP_DCMIPP_P1CCMRICR  \ offset: 0xB20 : DCMIPP Pipex current common ROI configuration register
$48002b24 constant DCMIPP_DCMIPP_P1CRI1CR1  \ offset: 0xB24 : DCMIPP Pipe1 current ROI1 configuration register 1
$48002b28 constant DCMIPP_DCMIPP_P1CRI1CR2  \ offset: 0xB28 : DCMIPP Pipe1 current ROI1 configuration register 2
$48002b2c constant DCMIPP_DCMIPP_P1CRI2CR1  \ offset: 0xB2C : DCMIPP Pipe1 current ROI2 configuration register 1
$48002b30 constant DCMIPP_DCMIPP_P1CRI2CR2  \ offset: 0xB30 : DCMIPP Pipe1 current ROI2 configuration register 2
$48002b34 constant DCMIPP_DCMIPP_P1CRI3CR1  \ offset: 0xB34 : DCMIPP Pipe1 current ROI3 configuration register 1
$48002b38 constant DCMIPP_DCMIPP_P1CRI3CR2  \ offset: 0xB38 : DCMIPP Pipe1 current ROI3 configuration register 2
$48002b3c constant DCMIPP_DCMIPP_P1CRI4CR1  \ offset: 0xB3C : DCMIPP Pipe1 current ROI4 configuration register 1
$48002b40 constant DCMIPP_DCMIPP_P1CRI4CR2  \ offset: 0xB40 : DCMIPP Pipe1 current ROI4 configuration register 2
$48002b44 constant DCMIPP_DCMIPP_P1CRI5CR1  \ offset: 0xB44 : DCMIPP Pipe1 current ROI5 configuration register 1
$48002b48 constant DCMIPP_DCMIPP_P1CRI5CR2  \ offset: 0xB48 : DCMIPP Pipe1 current ROI5 configuration register 2
$48002b4c constant DCMIPP_DCMIPP_P1CRI6CR1  \ offset: 0xB4C : DCMIPP Pipe1 current ROI6 configuration register 1
$48002b50 constant DCMIPP_DCMIPP_P1CRI6CR2  \ offset: 0xB50 : DCMIPP Pipe1 current ROI6 configuration register 2
$48002b54 constant DCMIPP_DCMIPP_P1CRI7CR1  \ offset: 0xB54 : DCMIPP Pipe1 current ROI7 configuration register 1
$48002b58 constant DCMIPP_DCMIPP_P1CRI7CR2  \ offset: 0xB58 : DCMIPP Pipe1 current ROI7 configuration register 2
$48002b5c constant DCMIPP_DCMIPP_P1CRI8CR1  \ offset: 0xB5C : DCMIPP Pipe1 current ROI8 configuration register 1
$48002b60 constant DCMIPP_DCMIPP_P1CRI8CR2  \ offset: 0xB60 : DCMIPP Pipe1 current ROI8 configuration register 2
$48002bc0 constant DCMIPP_DCMIPP_P1CPPCR  \ offset: 0xBC0 : DCMIPP Pipe1 current pixel packer configuration register
$48002bc4 constant DCMIPP_DCMIPP_P1CPPM0AR1  \ offset: 0xBC4 : DCMIPP Pipe1 current pixel packer Memory0 address register 1
$48002bc8 constant DCMIPP_DCMIPP_P1CPPM0AR2  \ offset: 0xBC8 : DCMIPP Pipe1 current pixel packer Memory0 address register 2
$48002bcc constant DCMIPP_DCMIPP_P1CPPM0PR  \ offset: 0xBCC : DCMIPP Pipex current pixel packer Memory0 pitch register
$48002bd4 constant DCMIPP_DCMIPP_P1CPPM1AR1  \ offset: 0xBD4 : DCMIPP Pipex current pixel packer Memory1 address register 1
$48002bd8 constant DCMIPP_DCMIPP_P1CPPM1AR2  \ offset: 0xBD8 : DCMIPP Pipex current pixel packer Memory1 address register 2
$48002bdc constant DCMIPP_DCMIPP_P1CPPM1PR  \ offset: 0xBDC : DCMIPP Pipex current pixel packer Memory1 pitch register
$48002be4 constant DCMIPP_DCMIPP_P1CPPM2AR1  \ offset: 0xBE4 : DCMIPP Pipex current pixel packer Memory2 address register 1
$48002be8 constant DCMIPP_DCMIPP_P1CPPM2AR2  \ offset: 0xBE8 : DCMIPP Pipex current pixel packer Memory2 address register 1
$48002c04 constant DCMIPP_DCMIPP_P2FSCR  \ offset: 0xC04 : DCMIPP Pipe2 flow selection configuration register
$48002d00 constant DCMIPP_DCMIPP_P2FCTCR  \ offset: 0xD00 : DCMIPP Pipex flow control configuration register
$48002d04 constant DCMIPP_DCMIPP_P2CRSTR  \ offset: 0xD04 : DCMIPP Pipex crop window start register
$48002d08 constant DCMIPP_DCMIPP_P2CRSZR  \ offset: 0xD08 : DCMIPP Pipex crop window size register
$48002d0c constant DCMIPP_DCMIPP_P2DCCR  \ offset: 0xD0C : DCMIPP Pipex decimation register
$48002d10 constant DCMIPP_DCMIPP_P2DSCR  \ offset: 0xD10 : DCMIPP Pipex downsize configuration register
$48002d14 constant DCMIPP_DCMIPP_P2DSRTIOR  \ offset: 0xD14 : DCMIPP Pipex downsize ratio register
$48002d18 constant DCMIPP_DCMIPP_P2DSSZR  \ offset: 0xD18 : DCMIPP Pipex downsize destination size register
$48002d20 constant DCMIPP_DCMIPP_P2CMRICR  \ offset: 0xD20 : DCMIPP Pipex common ROI configuration register
$48002d24 constant DCMIPP_DCMIPP_P2RI1CR1  \ offset: 0xD24 : DCMIPP Pipe2 ROI1 configuration register 1
$48002d28 constant DCMIPP_DCMIPP_P2RI1CR2  \ offset: 0xD28 : DCMIPP Pipe2 ROI1 configuration register 2
$48002d2c constant DCMIPP_DCMIPP_P2RI2CR1  \ offset: 0xD2C : DCMIPP Pipe2 ROI2 configuration register 1
$48002d30 constant DCMIPP_DCMIPP_P2RI2CR2  \ offset: 0xD30 : DCMIPP Pipe2 ROI2 configuration register 2
$48002d34 constant DCMIPP_DCMIPP_P2RI3CR1  \ offset: 0xD34 : DCMIPP Pipe2 ROI3 configuration register 1
$48002d38 constant DCMIPP_DCMIPP_P2RI3CR2  \ offset: 0xD38 : DCMIPP Pipe2 ROI3 configuration register 2
$48002d3c constant DCMIPP_DCMIPP_P2RI4CR1  \ offset: 0xD3C : DCMIPP Pipe2 ROI4 configuration register 1
$48002d40 constant DCMIPP_DCMIPP_P2RI4CR2  \ offset: 0xD40 : DCMIPP Pipe2 ROI4 configuration register 2
$48002d44 constant DCMIPP_DCMIPP_P2RI5CR1  \ offset: 0xD44 : DCMIPP Pipe2 ROI5 configuration register 1
$48002d48 constant DCMIPP_DCMIPP_P2RI5CR2  \ offset: 0xD48 : DCMIPP Pipe2 ROI5 configuration register 2
$48002d4c constant DCMIPP_DCMIPP_P2RI6CR1  \ offset: 0xD4C : DCMIPP Pipe2 ROI6 configuration register 1
$48002d50 constant DCMIPP_DCMIPP_P2RI6CR2  \ offset: 0xD50 : DCMIPP Pipe2 ROI6 configuration register 2
$48002d54 constant DCMIPP_DCMIPP_P2RI7CR1  \ offset: 0xD54 : DCMIPP Pipe2 ROI7 configuration register 1
$48002d58 constant DCMIPP_DCMIPP_P2RI7CR2  \ offset: 0xD58 : DCMIPP Pipe2 ROI7 configuration register 2
$48002d5c constant DCMIPP_DCMIPP_P2RI8CR1  \ offset: 0xD5C : DCMIPP Pipe2 ROI8 configuration register 1
$48002d60 constant DCMIPP_DCMIPP_P2RI8CR2  \ offset: 0xD60 : DCMIPP Pipe2 ROI8 configuration register 2
$48002d70 constant DCMIPP_DCMIPP_P2GMCR  \ offset: 0xD70 : DCMIPP Pipex gamma configuration register
$48002dc0 constant DCMIPP_DCMIPP_P2PPCR  \ offset: 0xDC0 : DCMIPP Pipe2 pixel packer configuration register
$48002dc4 constant DCMIPP_DCMIPP_P2PPM0AR1  \ offset: 0xDC4 : DCMIPP Pipe2 pixel packer Memory0 address register 1
$48002dc8 constant DCMIPP_DCMIPP_P2PPM0AR2  \ offset: 0xDC8 : DCMIPP Pipe2 pixel packer Memory0 address register 2
$48002dcc constant DCMIPP_DCMIPP_P2PPM0PR  \ offset: 0xDCC : DCMIPP Pipex pixel packer Memory0 pitch register
$48002dd0 constant DCMIPP_DCMIPP_P2STM0AR  \ offset: 0xDD0 : DCMIPP Pipex status Memory0 address register
$48002df4 constant DCMIPP_DCMIPP_P2IER  \ offset: 0xDF4 : DCMIPP Pipe2 interrupt enable register
$48002df8 constant DCMIPP_DCMIPP_P2SR  \ offset: 0xDF8 : DCMIPP Pipe2 status register
$48002dfc constant DCMIPP_DCMIPP_P2FCR  \ offset: 0xDFC : DCMIPP Pipe2 interrupt clear register
$48002e04 constant DCMIPP_DCMIPP_P2CFSCR  \ offset: 0xE04 : DCMIPP Pipe2 current flow selection configuration register
$48002f00 constant DCMIPP_DCMIPP_P2CFCTCR  \ offset: 0xF00 : DCMIPP Pipex current flow control configuration register
$48002f04 constant DCMIPP_DCMIPP_P2CCRSTR  \ offset: 0xF04 : DCMIPP Pipex current crop window start register
$48002f08 constant DCMIPP_DCMIPP_P2CCRSZR  \ offset: 0xF08 : DCMIPP Pipex current crop window size register
$48002f0c constant DCMIPP_DCMIPP_P2CDCCR  \ offset: 0xF0C : DCMIPP Pipex current decimation register
$48002f10 constant DCMIPP_DCMIPP_P2CDSCR  \ offset: 0xF10 : DCMIPP Pipex current downsize configuration register
$48002f14 constant DCMIPP_DCMIPP_P2CDSRTIOR  \ offset: 0xF14 : DCMIPP Pipex current downsize ratio register
$48002f18 constant DCMIPP_DCMIPP_P2CDSSZR  \ offset: 0xF18 : DCMIPP Pipex current downsize destination size register
$48002f20 constant DCMIPP_DCMIPP_P2CCMRICR  \ offset: 0xF20 : DCMIPP Pipex current common ROI configuration register
$48002f24 constant DCMIPP_DCMIPP_P2CRI1CR1  \ offset: 0xF24 : DCMIPP Pipe2 current ROI1 configuration register 1
$48002f28 constant DCMIPP_DCMIPP_P2CRI1CR2  \ offset: 0xF28 : DCMIPP Pipe2 current ROI1 configuration register 2
$48002f2c constant DCMIPP_DCMIPP_P2CRI2CR1  \ offset: 0xF2C : DCMIPP Pipe2 current ROI2 configuration register 1
$48002f30 constant DCMIPP_DCMIPP_P2CRI2CR2  \ offset: 0xF30 : DCMIPP Pipe2 current ROI2 configuration register 2
$48002f34 constant DCMIPP_DCMIPP_P2CRI3CR1  \ offset: 0xF34 : DCMIPP Pipe2 current ROI3 configuration register 1
$48002f38 constant DCMIPP_DCMIPP_P2CRI3CR2  \ offset: 0xF38 : DCMIPP Pipe2 current ROI3 configuration register 2
$48002f3c constant DCMIPP_DCMIPP_P2CRI4CR1  \ offset: 0xF3C : DCMIPP Pipe2 current ROI4 configuration register 1
$48002f40 constant DCMIPP_DCMIPP_P2CRI4CR2  \ offset: 0xF40 : DCMIPP Pipe2 current ROI4 configuration register 2
$48002f44 constant DCMIPP_DCMIPP_P2CRI5CR1  \ offset: 0xF44 : DCMIPP Pipe2 current ROI5 configuration register 1
$48002f48 constant DCMIPP_DCMIPP_P2CRI5CR2  \ offset: 0xF48 : DCMIPP Pipe2 current ROI5 configuration register 2
$48002f4c constant DCMIPP_DCMIPP_P2CRI6CR1  \ offset: 0xF4C : DCMIPP Pipe2 current ROI6 configuration register 1
$48002f50 constant DCMIPP_DCMIPP_P2CRI6CR2  \ offset: 0xF50 : DCMIPP Pipe2 current ROI6 configuration register 2
$48002f54 constant DCMIPP_DCMIPP_P2CRI7CR1  \ offset: 0xF54 : DCMIPP Pipe2 current ROI7 configuration register 1
$48002f58 constant DCMIPP_DCMIPP_P2CRI7CR2  \ offset: 0xF58 : DCMIPP Pipe2 current ROI7 configuration register 2
$48002f5c constant DCMIPP_DCMIPP_P2CRI8CR1  \ offset: 0xF5C : DCMIPP Pipe2 current ROI8 configuration register 1
$48002f60 constant DCMIPP_DCMIPP_P2CRI8CR2  \ offset: 0xF60 : DCMIPP Pipe2 current ROI8 configuration register 2
$48002fc0 constant DCMIPP_DCMIPP_P2CPPCR  \ offset: 0xFC0 : DCMIPP Pipe2 current pixel packer configuration register
$48002fc4 constant DCMIPP_DCMIPP_P2CPPM0AR1  \ offset: 0xFC4 : DCMIPP Pipe2 current pixel packer Memory0 address register 1
$48002fc8 constant DCMIPP_DCMIPP_P2CPPM0AR2  \ offset: 0xFC8 : DCMIPP Pipe2 current pixel packer Memory0 address register 2

