\
\ @file dcmipp.fs
\ @brief Digital camera interface pixel pipeline
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DCMIPP IP-Plug global register 1
\ Address offset: 0x00
\ Reset value: 0x00000002
\

$00000007 constant DCMIPP_DCMIPP_IPGR1_MEMORYPAGE                   \ Memory page size, as power of 2 of 64-byte units:
$01000000 constant DCMIPP_DCMIPP_IPGR1_QOS_MODE                     \ Quality of service Set of functions enabling to build and configure an architecture able to meet bandwidth and latency requirements.


\
\ @brief DCMIPP IP-Plug global register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_IPGR2_PSTART                       \ Request to lock the IP-Plug, to allow reconfiguration. PSTART must be reset to 0 after configuration is completed, to restart the IP-Plug.


\
\ @brief DCMIPP IP-Plug global register 3
\ Address offset: 0x08
\ Reset value: 0x00000001
\

$00000001 constant DCMIPP_DCMIPP_IPGR3_IDLE                         \ Status of IP-Plug IDLE is set some time after a request by setting PSTART at 1, and reset by resetting PSTART at 0.


\
\ @brief DCMIPP IP-Plug identification register
\ Address offset: 0x1C
\ Reset value: 0xAA040314
\

$0000003f constant DCMIPP_DCMIPP_IPGR8_DID                          \ Division identifier (0x14)
$00001f00 constant DCMIPP_DCMIPP_IPGR8_REVID                        \ Revision identifier (0x03)
$001f0000 constant DCMIPP_DCMIPP_IPGR8_ARCHIID                      \ Architecture identifier (0x04)
$ff000000 constant DCMIPP_DCMIPP_IPGR8_IPPID                        \ IP identifier (0xAA)


\
\ @brief DCMIPP IP-Plug Clientx register 1
\ Address offset: 0x20
\ Reset value: 0x00000003
\

$00000007 constant DCMIPP_DCMIPP_IPC1R1_TRAFFIC                     \ Burst size as power of 2 of 8-byte units Other values: Reserved
$00000300 constant DCMIPP_DCMIPP_IPC1R1_OTR                         \ Maximum outstanding transactions ... Other values are not allowed.


\
\ @brief DCMIPP IP-Plug Clientx register 2
\ Address offset: 0x24
\ Reset value: 0x00010000
\

$00000f00 constant DCMIPP_DCMIPP_IPC1R2_SVCMAPPING                  \ Non-user, must be kept at reset value.
$000f0000 constant DCMIPP_DCMIPP_IPC1R2_WLRU                        \ Ratio for WLRU[3:0] arbitration A client gets a portion of the total bandwidth = Ratio(client) / Sum(all ratio) ...


\
\ @brief DCMIPP IP-Plug Clientx register 3
\ Address offset: 0x28
\ Reset value: 0x001F0000
\

$0000001f constant DCMIPP_DCMIPP_IPC1R3_DPREGSTART                  \ Start word (AXI width = 64 bits) of the FIFO of Clientx.
$001f0000 constant DCMIPP_DCMIPP_IPC1R3_DPREGEND                    \ End word (AXI width = 64 bits) of the FIFO of Clientx. The addressed word is included in the FIFO, so that next DPREGSTART is DPREGEND + 1.


\
\ @brief DCMIPP parallel interface control register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000010 constant DCMIPP_DCMIPP_PRCR_ESS                           \ Embedded synchronization select Valid only for 8-bit parallel data. HSPOL/VSPOL are ignored when this bit is set.
$00000020 constant DCMIPP_DCMIPP_PRCR_PCKPOL                        \ Pixel clock polarity This bit configures the capture edge of the pixel clock
$00000040 constant DCMIPP_DCMIPP_PRCR_HSPOL                         \ Horizontal synchronization polarity This bit indicates the level on the HSYNC pin when the data are not valid on the parallel interface.
$00000080 constant DCMIPP_DCMIPP_PRCR_VSPOL                         \ Vertical synchronization polarity This bit indicates the level on the VSYNC pin when the data are not valid on the parallel interface.
$00001c00 constant DCMIPP_DCMIPP_PRCR_EDM                           \ Extended data mode Other values: Reserved.
$00004000 constant DCMIPP_DCMIPP_PRCR_ENABLE                        \ Parallel interface enable The parallel interface configuration registers must be correctly programmed before enabling this bit.
$00ff0000 constant DCMIPP_DCMIPP_PRCR_FORMAT                        \ Other values: data are captured and output as-is only through the data/dump pipeline (for example JPEG or byte input format). The monochrome Y input is inserted in the pipe as YUV pixels, with the U and V components set to neutral, to represent a grey color.
$02000000 constant DCMIPP_DCMIPP_PRCR_SWAPCYCLES                    \ Swap data (cycle 0 vs. cycle 1) for pixels received on two cycles The swap must not be activated by software for pixels received in one or three cycles.
$04000000 constant DCMIPP_DCMIPP_PRCR_SWAPBITS                      \ Swap LSB vs. MSB within each received component


\
\ @brief DCMIPP parallel interface embedded synchronization code register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$000000ff constant DCMIPP_DCMIPP_PRESCR_FSC                         \ Frame start delimiter code This byte specifies the code of the frame start delimiter. The code consists of four bytes in the form of 0xFF, 0x00, 0x00, FSC. If FSC is programmed to 0xFF, no frame start delimiter is detected, but the first occurrence of LSC after an FEC code is interpreted as the start of frame delimiter.
$0000ff00 constant DCMIPP_DCMIPP_PRESCR_LSC                         \ Line start delimiter code This byte specifies the code of the line start delimiter. The code consists of four bytes in the form of 0xFF, 0x00, 0x00, LSC.
$00ff0000 constant DCMIPP_DCMIPP_PRESCR_LEC                         \ Line end delimiter code This byte specifies the code of the line end delimiter. The code consists of four bytes in the form of 0xFF, 0x00, 0x00, LEC.
$ff000000 constant DCMIPP_DCMIPP_PRESCR_FEC                         \ Frame end delimiter code This byte specifies the code of the frame end delimiter. The code consists of four bytes in the form of 0xFF, 0x00, 0x00, FEC. If FEC is programmed to 0xFF, all the unused codes (0xFF00 00XY) are interpreted as frame end delimiters.


\
\ @brief DCMIPP parallel interface embedded synchronization unmask register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$000000ff constant DCMIPP_DCMIPP_PRESUR_FSU                         \ Frame start delimiter unmask This byte specifies the mask to be applied to the code of the frame start delimiter.
$0000ff00 constant DCMIPP_DCMIPP_PRESUR_LSU                         \ Line start delimiter unmask This byte specifies the mask to be applied to the code of the line start delimiter.
$00ff0000 constant DCMIPP_DCMIPP_PRESUR_LEU                         \ Line end delimiter unmask This byte specifies the mask to be applied to the code of the line end delimiter.
$ff000000 constant DCMIPP_DCMIPP_PRESUR_FEU                         \ Frame end delimiter unmask This byte specifies the mask to be applied to the code of the frame end delimiter.


\
\ @brief DCMIPP parallel interface interrupt enable register
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$00000040 constant DCMIPP_DCMIPP_PRIER_ERRIE                        \ Synchronization error interrupt enable This bit is available only in embedded synchronization mode.


\
\ @brief DCMIPP parallel interface status register
\ Address offset: 0x1F8
\ Reset value: 0x00030000
\

$00000040 constant DCMIPP_DCMIPP_PRSR_ERRF                          \ Synchronization error raw interrupt status This bit is valid only in the embedded synchronization mode. It is cleared by writing a 1 to the CERRF bit in DCMIPP_PRFCR. This bit is available only in embedded synchronization mode.
$00010000 constant DCMIPP_DCMIPP_PRSR_HSYNC                         \ This bit gives the state of the HSYNC pin with the correct programmed polarity if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in HPOL bit, and cleared otherwise. When embedded synchronization codes are used: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in DCMIPP_CR is set.
$00020000 constant DCMIPP_DCMIPP_PRSR_VSYNC                         \ This bit gives the state of the VSYNC pin with the correct programmed polarity if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in VPOL bit, and cleared otherwise. When embedded synchronization codes are used: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in DCMIPP_CR is set.


\
\ @brief DCMIPP parallel interface interrupt clear register
\ Address offset: 0x1FC
\ Reset value: 0x00000000
\

$00000040 constant DCMIPP_DCMIPP_PRFCR_CERRF                        \ Synchronization error interrupt status clear Writing a 1 into this bit clears the ERRF bit in DCMIPP_PRSR. This bit is available only in embedded synchronization mode.


\
\ @brief DCMIPP common configuration register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000010 constant DCMIPP_DCMIPP_CMCR_CFC                           \ Clear frame counter When this bit is set, the frame counter associated to a pipe is cleared. It resets DCMIPP_CMFRCR register. This bit is always read at 0.


\
\ @brief DCMIPP common frame counter register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_CMFRCR_FRMCNT                      \ Frame counter, read-only, loops around. Incremented following VSYNC detection mapped to the pipe configured into bits PSFC[1:0] of the DCMIPP_CMCR register. The counter is cleared using the CRC bit in the DCMIPP_CMCR register.


\
\ @brief DCMIPP common interrupt enable register
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$00000020 constant DCMIPP_DCMIPP_CMIER_ATXERRIE                     \ AXI transfer error interrupt enable for IP-Plug
$00000040 constant DCMIPP_DCMIPP_CMIER_PRERRIE                      \ Limit interrupt enable for the parallel Interface
$00000100 constant DCMIPP_DCMIPP_CMIER_P0LINEIE                     \ Multi-line capture complete interrupt enable for Pipe0
$00000200 constant DCMIPP_DCMIPP_CMIER_P0FRAMEIE                    \ Frame capture complete interrupt enable for Pipe0
$00000400 constant DCMIPP_DCMIPP_CMIER_P0VSYNCIE                    \ Vertical sync interrupt enable for Pipe0
$00004000 constant DCMIPP_DCMIPP_CMIER_P0LIMITIE                    \ Limit interrupt enable for Pipe0
$00008000 constant DCMIPP_DCMIPP_CMIER_P0OVRIE                      \ Overrun interrupt enable for Pipe0


\
\ @brief DCMIPP common status register 1
\ Address offset: 0x3F4
\ Reset value: 0x00000003
\

$00000001 constant DCMIPP_DCMIPP_CMSR1_PRHSYNC                      \ This bit gives the state of the HSYNC pin with the correct programmed polarity on the parallel interface if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in HPOL bit of the DCMIPP_PRCR register, and cleared otherwise. When embedded synchronization codes are used the meaning of this bit is the following: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in the DCMIPP_PRCR register is set.
$00000002 constant DCMIPP_DCMIPP_CMSR1_PRVSYNC                      \ This bit gives the state of the VSYNC pin with the correct programmed polarity on the parallel interface if ENABLE bit is set into the DCMIPP_PRCR register and if the pixel clock is received. It is set during the blanking period whatever the polarity selected in VPOL bit of the DCMIPP_PRCR register, and cleared otherwise. When embedded synchronization codes are used, the meaning of this bit is the following: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in the DCMIPP_PRCR register is set.
$00008000 constant DCMIPP_DCMIPP_CMSR1_P0CPTACT                     \ Active frame capture (active from start-of-frame to frame complete) for Pipe0


\
\ @brief DCMIPP common status register 2
\ Address offset: 0x3F8
\ Reset value: 0x00000000
\

$00000020 constant DCMIPP_DCMIPP_CMSR2_ATXERRF                      \ AXI transfer error interrupt status flag for the IP-Plug. This bit is cleared by writing a 1 to CATXERRF bit in the DCMIPP_CMFCR register.
$00000040 constant DCMIPP_DCMIPP_CMSR2_PRERRF                       \ Synchronization error raw interrupt status for the parallel interface. This bit is valid only in the embedded synchronization mode. It is cleared by writing a 1 to the CPRERRF bit in the DCMIPP_CMFCR register. This bit is available only in embedded synchronization mode.
$00000100 constant DCMIPP_DCMIPP_CMSR2_P0LINEF                      \ Multi-line capture completed raw interrupt status for Pipe0 This bit is set when one/more lines have been completed. The periodicity of LINEF event is configured by LINEMULT bits into DCMIPP_P0PPCR register. When reaching end of frame, this event is triggered out to allow software action even if the LINEMULT value set is not a multiple of the total lines frame. In the case of embedded synchronization, this bit is set only if the CAPTURE bit in the DCMIPP_CR register is set. It is cleared by writing a 1 to the CP0LINEF bit in the DCMIPP_CMFCR register.
$00000200 constant DCMIPP_DCMIPP_CMSR2_P0FRAMEF                     \ Frame capture completed raw interrupt status for Pipe0 This bit is set when all data of a frame or window have been captured. In case of a cropped window, this bit is set at the end of line of the last line in the crop, even if the captured frame is empty (for example window cropped outside the frame). This bit is cleared by writing a 1 to the CP0FRAMEF bit in the DCMIPP_CMFCR register.
$00000400 constant DCMIPP_DCMIPP_CMSR2_P0VSYNCF                     \ VSYNC raw interrupt status for Pipe0 This bit is set when the VSYNC signal changes from the inactive state to the active state. In the case of embedded synchronization, this bit is set only if the CAPTURE bit is set in DCMIPP_CR. It is cleared by writing a 1 to the CP0VSYNCF bit in the DCMIPP_CMFCR register.
$00004000 constant DCMIPP_DCMIPP_CMSR2_P0LIMITF                     \ Limit raw interrupt status for Pipe0 This bit is set when the data counter DCMIPP_P0DCCNT reaches its maximum value DCMIPP_P0DCLIMIT. It is cleared by writing a 1 to the CP0LIMITF bit in the DCMIPP_CMFCR register.
$00008000 constant DCMIPP_DCMIPP_CMSR2_P0OVRF                       \ Overrun raw interrupt status for Pipe0 This bit is cleared by writing a 1 to the CP0OVRF bit in the DCMIPP_CMFCR register.


\
\ @brief DCMIPP common interrupt clear register
\ Address offset: 0x3FC
\ Reset value: 0x00000000
\

$00000020 constant DCMIPP_DCMIPP_CMFCR_CATXERRF                     \ AXI transfer error interrupt status clear Writing a 1 into this bit clears the ATXERRF bit in the DCMIPP_CMSR2 register.
$00000040 constant DCMIPP_DCMIPP_CMFCR_CPRERRF                      \ Synchronization error interrupt status clear Writing a 1 into this bit clears the PRERRF bit in the DCMIPP_CMSR2 register. This bit is available only in embedded synchronization mode.
$00000100 constant DCMIPP_DCMIPP_CMFCR_CP0LINEF                     \ Multi-line capture complete interrupt status clear Writing a 1 into this bit clears P0LINEF in the DCMIPP_CMSR2 register
$00000200 constant DCMIPP_DCMIPP_CMFCR_CP0FRAMEF                    \ Frame capture complete interrupt status clear Writing a 1 into this bit clears the P0FRAMEF bit in the DCMIPP_CMSR2 register.
$00000400 constant DCMIPP_DCMIPP_CMFCR_CP0VSYNCF                    \ Vertical synchronization interrupt status clear Writing a 1 into this bit clears the P0VSYNCF bit in the DCMIPP_CMSR2 register.
$00004000 constant DCMIPP_DCMIPP_CMFCR_CP0LIMITF                    \ limit interrupt status clear Writing a 1 into this bit clears P0LIMITF in the DCMIPP_CMSR2 register
$00008000 constant DCMIPP_DCMIPP_CMFCR_CP0OVRF                      \ Overrun interrupt status clear Writing a 1 into this bit clears the P0OVRF bit in the DCMIPP_CMSR2 register


\
\ @brief DCMIPP Pipe0 flow selection configuration register
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$80000000 constant DCMIPP_DCMIPP_P0FSCR_PIPEN                       \ Activation of PipeN Note: This bit is not shadowed, differently from all other bits in this register.


\
\ @brief DCMIPP Pipe0 flow control configuration register
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P0FCTCR_FRATE                      \ Frame capture rate control These bits define the frequency of frame capture. They are meaningful only in Continuous grab mode, ignored in Snapshot mode.
$00000004 constant DCMIPP_DCMIPP_P0FCTCR_CPTMODE                    \ Capture mode
$00000008 constant DCMIPP_DCMIPP_P0FCTCR_CPTREQ                     \ Capture requested When PIPEN = 1 and when the CPTREQ is set to 1 the pipe waits for the first VSync, and automatically starts a capture and sets CPTACT = 1 to mention it. In Snapshot mode the CPTREQ bit is automatically cleared at the start of the first received frame. In Continuous grab mode, the capture remains active and CPTREQ = 1 until the software clears CPTREQ: the capture stops and CPTACT is reset at the end of the ongoing frame. The DCMI and pipe configuration registers must be correctly programmed before enabling this bit.


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

$00000fff constant DCMIPP_DCMIPP_P0SCSZR_HSIZE                      \ Horizontal size, from 0 to 4094 word wide (data 32-bit) If the value is maintained at 0 when enabling the crop by means of ENABLE bit, the crop operation is not performed on horizontal direction.
$0fff0000 constant DCMIPP_DCMIPP_P0SCSZR_VSIZE                      \ Vertical size, from 0 to 4094 pixels high If the value is maintained at 0 when enabling the crop by means of ENABLE bit, the crop operation is not performed on vertical direction.
$40000000 constant DCMIPP_DCMIPP_P0SCSZR_POSNEG                     \ This bit is set and cleared by software. It has a meaning only if ENABLE bit is set.
$80000000 constant DCMIPP_DCMIPP_P0SCSZR_ENABLE                     \ This bit is set and cleared by software. if POSNEG = 0, the data inside the rectangle area are transmitted (it can correspond to a statistical data removal, or as a crop feature in a data valid image area). if POSNEG = 1, the data outside of the rectangle area are transmitted (it can correspond to a statistical data extraction, rejecting all data inside the window). This bit must be kept cleared if the input format is JPEG, to avoid unpredictable behavior of the pipe.


\
\ @brief DCMIPP Pipe0 dump counter register
\ Address offset: 0x5B0
\ Reset value: 0x00000000
\

$03ffffff constant DCMIPP_DCMIPP_P0DCCNTR_CNT                       \ Number of data dumped during the frame. The size of the data is expressed in bytes. It counts only the data selected by means of the CROP 2D function. The counter saturates at 0x3FFFFFF. Granularity is 32-bit for all the formats except for the byte stream formats (for example JPEG) having byte granularity.


\
\ @brief DCMIPP Pipe0 dump limit register
\ Address offset: 0x5B4
\ Reset value: 0x00FFFFFF
\

$00ffffff constant DCMIPP_DCMIPP_P0DCLMTR_LIMIT                     \ Maximum number of 32-bit data that can be dumped during a frame, after the crop 2D operation.
$80000000 constant DCMIPP_DCMIPP_P0DCLMTR_ENABLE                    \ Disabled, no check on the amount of 32-bit words transmitted


\
\ @brief DCMIPP Pipe0 pixel packer configuration register
\ Address offset: 0x5C0
\ Reset value: 0x00000000
\

$00000020 constant DCMIPP_DCMIPP_P0PPCR_PAD                         \ Pad mode for monochrome and raw Bayer 10/12/14 bpp: MSB vs. LSB alignment.
$00000180 constant DCMIPP_DCMIPP_P0PPCR_BSM                         \ Byte select mode Modes 10 and 11 work only with EDM [2:0] = 000 into the DCMIPP_PRCR register.
$00000200 constant DCMIPP_DCMIPP_P0PPCR_OEBS                        \ Odd/even byte select (byte select start) This bit works in conjunction with BSM field (BSM different from 00)
$00000400 constant DCMIPP_DCMIPP_P0PPCR_LSM                         \ Line select mode
$00000800 constant DCMIPP_DCMIPP_P0PPCR_OELS                        \ Odd/even line select (line select start) This bit works in conjunction with LSM field (LSM = 1).
$0000e000 constant DCMIPP_DCMIPP_P0PPCR_LINEMULT                    \ Amount of capture completed lines for LINE event and interrupt
$00010000 constant DCMIPP_DCMIPP_P0PPCR_DBM                         \ Double buffer mode This bit is set and cleared by software.


\
\ @brief DCMIPP Pipe0 pixel packer Memory0 address register 1
\ Address offset: 0x5C4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P0PPM0AR1_M0A                      \ Memory0 address Base address of memory area 0, to whom data are written. It is assumed to be a multiple of 16, hence its bits 3:0 are always at 0x0.


\
\ @brief DCMIPP Pipe0 pixel packer Memory0 address register 2
\ Address offset: 0x5C8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P0PPM0AR2_M0A                      \ Memory0 address Base address of memory area 0, to whom data are written. It is assumed to be a multiple of 16, hence its bits 3:0 are always at 0x0.


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

$00000001 constant DCMIPP_DCMIPP_P0SR_LINEF                         \ Multi-line capture completed raw interrupt status This bit is set when one/more lines have been completed. For the JPEG mode, this bit is raised at the end of the frame. The periodicity of LINEF event is configured by LINEMULT bits into DCMIPP_P0PPCR register. When reaching end of frame, this event is triggered out to allow software action even if the LINEMULT value set is not a multiple of the total lines frame. In case of embedded synchronization, this bit is set only if the CAPTURE bit in the DCMIPP_CR register is set. It is cleared by writing a 1 to the CLINEF bit in the DCMIPP_P0FCR register.
$00000002 constant DCMIPP_DCMIPP_P0SR_FRAMEF                        \ Frame capture completed raw interrupt status This bit is set when all data of a frame or window have been captured. In case of a cropped window, this bit is set at the end of line of the last line in the crop. It is set even if the captured frame is empty (for example window cropped outside the frame). This bit is cleared by writing a 1 to the CFRAMEF bit in DCMIPP_P0FCR.
$00000004 constant DCMIPP_DCMIPP_P0SR_VSYNCF                        \ VSYNC raw interrupt status This bit is set when the VSYNC signal changes from the inactive state to the active state. In case of embedded synchronization, this bit is set only if the CAPTURE bit is set in DCMIPP_CR. It is cleared by writing a 1 to the CVSYNCF bit in the DCMIPP_P0FCR register.
$00000040 constant DCMIPP_DCMIPP_P0SR_LIMITF                        \ Limit raw interrupt status This bit is set when the data counter DCMIPP_PxDCCNTR reaches its maximum value DCMIPP_PxDCLIMITR. It is cleared by writing a 1 to the CLIMITF bit in the DCMIPP_P0FCR register.
$00000080 constant DCMIPP_DCMIPP_P0SR_OVRF                          \ Overrun raw interrupt status This bit is cleared by writing a 1 to the COVRF bit in the DCMIPP_P0FCR register.
$00800000 constant DCMIPP_DCMIPP_P0SR_CPTACT                        \ Capture immediate status This bit is automatically reset at the end of frame capture complete event (after all the data of that frame have been captured and the IP-Plug has started to emit the last burst on the AXI, usually before the next VSync).


\
\ @brief DCMIPP Pipe0 interrupt clear register
\ Address offset: 0x5FC
\ Reset value: 0x00000000
\

$00000001 constant DCMIPP_DCMIPP_P0FCR_CLINEF                       \ Multi-line capture complete interrupt status clear Writing a 1 into this bit clears LINEF in the DCMIPP_P0SR register.
$00000002 constant DCMIPP_DCMIPP_P0FCR_CFRAMEF                      \ Frame capture complete interrupt status clear Writing a 1 into this bit clears the FRAMEF bit in the DCMIPP_P0SR register.
$00000004 constant DCMIPP_DCMIPP_P0FCR_CVSYNCF                      \ Vertical synchronization interrupt status clear Writing a 1 into this bit clears the VSYNCF bit in the DCMIPP_P0SR register.
$00000040 constant DCMIPP_DCMIPP_P0FCR_CLIMITF                      \ limit interrupt status clear Writing a 1 into this bit clears LIMITF in the DCMIPP_P0SR register.
$00000080 constant DCMIPP_DCMIPP_P0FCR_COVRF                        \ Overrun interrupt status clear Writing a 1 into this bit clears the OVRF bit in the DCMIPP_P0SR register.


\
\ @brief DCMIPP Pipe0 current flow control configuration register
\ Address offset: 0x700
\ Reset value: 0x00000000
\

$00000003 constant DCMIPP_DCMIPP_P0CFCTCR_FRATE                     \ Frame capture rate control These bits define the frequency of frame capture. They are meaningful only in Continuous grab mode, ignored in Snapshot mode.
$00000004 constant DCMIPP_DCMIPP_P0CFCTCR_CPTMODE                   \ Capture mode
$00000008 constant DCMIPP_DCMIPP_P0CFCTCR_CPTREQ                    \ Capture requested When PIPEN = 1, and when the CPTREQ is set to 1 the pipe waits for the first VSync, and automatically starts a capture and sets CPTACT = 1 to mention it. In Snapshot mode the CPTREQ bit is automatically cleared at the start of the first frame received. In continuous grab mode the capture remains active and CPTREQ = 1, until the software clears CPTREQ: the capture stops and CPTACT is reset at the end of the ongoing frame. The DCMI and pipe configuration registers must be correctly programmed before enabling this bit.


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

$00000fff constant DCMIPP_DCMIPP_P0CSCSZR_HSIZE                     \ Current horizontal size, from 0 to 4094 word wide (data 32-bit). If the value is maintained at 0 when enabling the crop by means of the ENABLE bit, the value is forced internally at 0xFFE, which is the maximum value.
$0fff0000 constant DCMIPP_DCMIPP_P0CSCSZR_VSIZE                     \ Current vertical size, from 0 to 4094 pixels high. If the value is maintained at 0 when enabling the crop by means of the ENABLE bit, the value is forced internally at 0xFFE which is the maximum value.
$40000000 constant DCMIPP_DCMIPP_P0CSCSZR_POSNEG                    \ Current value of the POSNEG bit This bit has a meaning only if ENABLE bit is set.
$80000000 constant DCMIPP_DCMIPP_P0CSCSZR_ENABLE                    \ Current value of the ENABLE bit if POSNEG = 0, the data inside the rectangle area are transmitted (can correspond to a statistical data removal, or as a crop feature in a data valid image area). if POSNEG = 1, the data outside of the rectangle area are transmitted (can correspond to a statistical data extraction, rejecting all data inside the window)


\
\ @brief DCMIPP Pipe0 current pixel packer configuration register
\ Address offset: 0x7C0
\ Reset value: 0x00000000
\

$00000020 constant DCMIPP_DCMIPP_P0CPPCR_PAD                        \ Current Pad mode for monochrome and raw Bayer 10/12/14 bpp: MSB vs. LSB alignment
$00000180 constant DCMIPP_DCMIPP_P0CPPCR_BSM                        \ Current Byte select mode Modes 10 and 11 work only with EDM [2:0] = 000 into the DCMIPP_PRCR register.
$00000200 constant DCMIPP_DCMIPP_P0CPPCR_OEBS                       \ Current odd/even byte select (byte select start) This bit works in conjunction with BSM field (BSM different from 00)
$00000400 constant DCMIPP_DCMIPP_P0CPPCR_LSM                        \ Current Line select mode
$00000800 constant DCMIPP_DCMIPP_P0CPPCR_OELS                       \ Current odd/even line select (ine select start) This bit works in conjunction with LSM field (LSM = 1)
$0000e000 constant DCMIPP_DCMIPP_P0CPPCR_LINEMULT                   \ Current amount of capture completed lines for LINE event and interrupt
$00010000 constant DCMIPP_DCMIPP_P0CPPCR_DBM                        \ Double buffer mode


\
\ @brief DCMIPP Pipe0 current pixel packer Memory0 address register 1
\ Address offset: 0x7C4
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P0CPPM0AR1_M0A                     \ Memory0 address Base address of the current memory area 0, to whom data are written. It is assumed to be a multiple of 16, hence its bits 3:0 are always at 0x0.


\
\ @brief DCMIPP Pipe0 current pixel packer Memory0 address register 2
\ Address offset: 0x7C8
\ Reset value: 0x00000000
\

$00000000 constant DCMIPP_DCMIPP_P0CPPM0AR2_M0A                     \ Memory0 address Base address of the current memory area 0, to whom data are written. It is assumed to be a multiple of 16, hence its bits 3:0 are always at 0x0.


\
\ @brief Digital camera interface pixel pipeline
\
$50002000 constant DCMIPP_DCMIPP_IPGR1  \ offset: 0x00 : DCMIPP IP-Plug global register 1
$50002004 constant DCMIPP_DCMIPP_IPGR2  \ offset: 0x04 : DCMIPP IP-Plug global register 2
$50002008 constant DCMIPP_DCMIPP_IPGR3  \ offset: 0x08 : DCMIPP IP-Plug global register 3
$5000201c constant DCMIPP_DCMIPP_IPGR8  \ offset: 0x1C : DCMIPP IP-Plug identification register
$50002020 constant DCMIPP_DCMIPP_IPC1R1  \ offset: 0x20 : DCMIPP IP-Plug Clientx register 1
$50002024 constant DCMIPP_DCMIPP_IPC1R2  \ offset: 0x24 : DCMIPP IP-Plug Clientx register 2
$50002028 constant DCMIPP_DCMIPP_IPC1R3  \ offset: 0x28 : DCMIPP IP-Plug Clientx register 3
$50002104 constant DCMIPP_DCMIPP_PRCR  \ offset: 0x104 : DCMIPP parallel interface control register
$50002108 constant DCMIPP_DCMIPP_PRESCR  \ offset: 0x108 : DCMIPP parallel interface embedded synchronization code register
$5000210c constant DCMIPP_DCMIPP_PRESUR  \ offset: 0x10C : DCMIPP parallel interface embedded synchronization unmask register
$500021f4 constant DCMIPP_DCMIPP_PRIER  \ offset: 0x1F4 : DCMIPP parallel interface interrupt enable register
$500021f8 constant DCMIPP_DCMIPP_PRSR  \ offset: 0x1F8 : DCMIPP parallel interface status register
$500021fc constant DCMIPP_DCMIPP_PRFCR  \ offset: 0x1FC : DCMIPP parallel interface interrupt clear register
$50002204 constant DCMIPP_DCMIPP_CMCR  \ offset: 0x204 : DCMIPP common configuration register
$50002208 constant DCMIPP_DCMIPP_CMFRCR  \ offset: 0x208 : DCMIPP common frame counter register
$500023f0 constant DCMIPP_DCMIPP_CMIER  \ offset: 0x3F0 : DCMIPP common interrupt enable register
$500023f4 constant DCMIPP_DCMIPP_CMSR1  \ offset: 0x3F4 : DCMIPP common status register 1
$500023f8 constant DCMIPP_DCMIPP_CMSR2  \ offset: 0x3F8 : DCMIPP common status register 2
$500023fc constant DCMIPP_DCMIPP_CMFCR  \ offset: 0x3FC : DCMIPP common interrupt clear register
$50002404 constant DCMIPP_DCMIPP_P0FSCR  \ offset: 0x404 : DCMIPP Pipe0 flow selection configuration register
$50002500 constant DCMIPP_DCMIPP_P0FCTCR  \ offset: 0x500 : DCMIPP Pipe0 flow control configuration register
$50002504 constant DCMIPP_DCMIPP_P0SCSTR  \ offset: 0x504 : DCMIPP Pipe0 stat/crop start register
$50002508 constant DCMIPP_DCMIPP_P0SCSZR  \ offset: 0x508 : DCMIPP Pipe0 stat/crop size register
$500025b0 constant DCMIPP_DCMIPP_P0DCCNTR  \ offset: 0x5B0 : DCMIPP Pipe0 dump counter register
$500025b4 constant DCMIPP_DCMIPP_P0DCLMTR  \ offset: 0x5B4 : DCMIPP Pipe0 dump limit register
$500025c0 constant DCMIPP_DCMIPP_P0PPCR  \ offset: 0x5C0 : DCMIPP Pipe0 pixel packer configuration register
$500025c4 constant DCMIPP_DCMIPP_P0PPM0AR1  \ offset: 0x5C4 : DCMIPP Pipe0 pixel packer Memory0 address register 1
$500025c8 constant DCMIPP_DCMIPP_P0PPM0AR2  \ offset: 0x5C8 : DCMIPP Pipe0 pixel packer Memory0 address register 2
$500025f4 constant DCMIPP_DCMIPP_P0IER  \ offset: 0x5F4 : DCMIPP Pipe0 interrupt enable register
$500025f8 constant DCMIPP_DCMIPP_P0SR  \ offset: 0x5F8 : DCMIPP Pipe0 status register
$500025fc constant DCMIPP_DCMIPP_P0FCR  \ offset: 0x5FC : DCMIPP Pipe0 interrupt clear register
$50002700 constant DCMIPP_DCMIPP_P0CFCTCR  \ offset: 0x700 : DCMIPP Pipe0 current flow control configuration register
$50002704 constant DCMIPP_DCMIPP_P0CSCSTR  \ offset: 0x704 : DCMIPP Pipe0 current stat/crop start register
$50002708 constant DCMIPP_DCMIPP_P0CSCSZR  \ offset: 0x708 : DCMIPP Pipe0 current stat/crop size register
$500027c0 constant DCMIPP_DCMIPP_P0CPPCR  \ offset: 0x7C0 : DCMIPP Pipe0 current pixel packer configuration register
$500027c4 constant DCMIPP_DCMIPP_P0CPPM0AR1  \ offset: 0x7C4 : DCMIPP Pipe0 current pixel packer Memory0 address register 1
$500027c8 constant DCMIPP_DCMIPP_P0CPPM0AR2  \ offset: 0x7C8 : DCMIPP Pipe0 current pixel packer Memory0 address register 2

