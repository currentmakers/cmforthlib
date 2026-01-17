\
\ @file dcmi.fs
\ @brief Digital camera interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DCMI_DEF

  [ifdef] DCMI_DCMI_CR_DEF
    \
    \ @brief DCMI control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_CAPTURE                   \ [0x00] Capture enable The camera interface waits for the first start of frame, then a DMA request is generated to transfer the received data into the destination memory. In snapshot mode, the CAPTURE bit is automatically cleared at the end of the first frame received. In continuous grab mode, if the software clears this bit while a capture is ongoing, the bit is effectively cleared after the frame end. Note: The DMA controller and all DCMI configuration registers must be programmed correctly before enabling this bit.
    $01 constant DCMI_CM                        \ [0x01] Capture mode
    $02 constant DCMI_CROP                      \ [0x02] Crop feature
    $03 constant DCMI_JPEG                      \ [0x03] JPEG format
    $04 constant DCMI_ESS                       \ [0x04] Embedded synchronization select Note: Valid only for 8-bit parallel data. HSPOL/VSPOL are ignored when the ESS bit is set. This bit is disabled in JPEG mode.
    $05 constant DCMI_PCKPOL                    \ [0x05] Pixel clock polarity This bit configures the capture edge of the pixel clock.
    $06 constant DCMI_HSPOL                     \ [0x06] Horizontal synchronization polarity This bit indicates the level on the DCMI_HSYNC pin when the data are not valid on the parallel interface.
    $07 constant DCMI_VSPOL                     \ [0x07] Vertical synchronization polarity This bit indicates the level on the DCMI_VSYNC pin when the data are not valid on the parallel interface.
    $08 constant DCMI_FCRC                      \ [0x08 : 2] Frame capture rate control These bits define the frequency of frame capture. They are meaningful only in Continuous grab mode. They are ignored in snapshot mode.
    $0a constant DCMI_EDM                       \ [0x0a : 2] Extended data mode
    $0e constant DCMI_ENABLE                    \ [0x0e] DCMI enable Note: The DCMI configuration registers must be programmed correctly before enabling this bit.
    $10 constant DCMI_BSM                       \ [0x10 : 2] Byte Select mode Note: This mode only works for EDM[1:0] = 00. For all other EDM values, this field must be programmed to the reset value.
    $12 constant DCMI_OEBS                      \ [0x12] Odd/Even Byte Select (Byte Select Start) This bit works in conjunction with BSM field (BSM different 00).
    $13 constant DCMI_LSM                       \ [0x13] Line Select mode
    $14 constant DCMI_OELS                      \ [0x14] Odd/Even Line Select (Line Select Start) This bit works in conjunction with the LSM field (LSM = 1).
  [then]


  [ifdef] DCMI_DCMI_SR_DEF
    \
    \ @brief DCMI status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_HSYNC                     \ [0x00] Horizontal synchronization This bit gives the state of the DCMI_HSYNC pin with the correct programmed polarity. When embedded synchronization codes are used, the meaning of this bit is the following: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in DCMI_CR is set.
    $01 constant DCMI_VSYNC                     \ [0x01] Vertical synchronization This bit gives the state of the DCMI_VSYNC pin with the correct programmed polarity. When embedded synchronization codes are used, the meaning of this bit is the following: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in DCMI_CR is set.
    $02 constant DCMI_FNE                       \ [0x02] FIFO not empty This bit gives the status of the FIFO.
  [then]


  [ifdef] DCMI_DCMI_RIS_DEF
    \
    \ @brief DCMI raw interrupt status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_RIS                 \ [0x00] Capture complete raw interrupt status This bit is set when a frame or window has been captured. In case of a cropped window, this bit is set at the end of line of the last line in the crop. It is set even if the captured frame is empty (e.g. window cropped outside the frame). The bit is cleared by setting the FRAME_ISC bit of the DCMI_ICR register.
    $01 constant DCMI_OVR_RIS                   \ [0x01] Overrun raw interrupt status The bit is cleared by setting the OVR_ISC bit of the DCMI_ICR register.
    $02 constant DCMI_ERR_RIS                   \ [0x02] Synchronization error raw interrupt status This bit is valid only in the embedded synchronization mode. It is cleared by setting the ERR_ISC bit of the DCMI_ICR register. Note: This bit is available only in embedded synchronization mode.
    $03 constant DCMI_VSYNC_RIS                 \ [0x03] DCMI_VSYNC raw interrupt status This bit is set when the DCMI_VSYNC signal changes from the inactive state to the active state. In the case of embedded synchronization, this bit is set only if the CAPTURE bit is set in DCMI_CR. It is cleared by setting the VSYNC_ISC bit of the DCMI_ICR register.
    $04 constant DCMI_LINE_RIS                  \ [0x04] Line raw interrupt status This bit gets set when the DCMI_HSYNC signal changes from the inactive state to the active state. It goes high even if the line is not valid. In the case of embedded synchronization, this bit is set only if the CAPTURE bit in DCMI_CR is set. It is cleared by setting the LINE_ISC bit of the DCMI_ICR register.
  [then]


  [ifdef] DCMI_DCMI_IER_DEF
    \
    \ @brief DCMI interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_IE                  \ [0x00] Capture complete interrupt enable
    $01 constant DCMI_OVR_IE                    \ [0x01] Overrun interrupt enable
    $02 constant DCMI_ERR_IE                    \ [0x02] Synchronization error interrupt enable Note: This bit is available only in embedded synchronization mode.
    $03 constant DCMI_VSYNC_IE                  \ [0x03] DCMI_VSYNC interrupt enable The active state of the DCMI_VSYNC signal is defined by the VSPOL bit.
    $04 constant DCMI_LINE_IE                   \ [0x04] Line interrupt enable
  [then]


  [ifdef] DCMI_DCMI_MIS_DEF
    \
    \ @brief DCMI masked interrupt status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_MIS                 \ [0x00] Capture complete masked interrupt status This bit gives the status of the masked capture complete interrupt
    $01 constant DCMI_OVR_MIS                   \ [0x01] Overrun masked interrupt status This bit gives the status of the masked overflow interrupt.
    $02 constant DCMI_ERR_MIS                   \ [0x02] Synchronization error masked interrupt status This bit gives the status of the masked synchronization error interrupt. Note: This bit is available only in embedded synchronization mode.
    $03 constant DCMI_VSYNC_MIS                 \ [0x03] VSYNC masked interrupt status This bit gives the status of the masked VSYNC interrupt. The active state of the DCMI_VSYNC signal is defined by the VSPOL bit.
    $04 constant DCMI_LINE_MIS                  \ [0x04] Line masked interrupt status This bit gives the status of the masked line interrupt.
  [then]


  [ifdef] DCMI_DCMI_ICR_DEF
    \
    \ @brief DCMI interrupt clear register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_ISC                 \ [0x00] Capture complete interrupt status clear Setting this bit clears the FRAME_RIS flag in the DCMI_RIS register.
    $01 constant DCMI_OVR_ISC                   \ [0x01] Overrun interrupt status clear Setting this bit clears the OVR_RIS flag in the DCMI_RIS register.
    $02 constant DCMI_ERR_ISC                   \ [0x02] Synchronization error interrupt status clear Setting this bit clears the ERR_RIS flag in the DCMI_RIS register. Note: This bit is available only in embedded synchronization mode.
    $03 constant DCMI_VSYNC_ISC                 \ [0x03] Vertical Synchronization interrupt status clear Setting this bit clears the VSYNC_RIS flag in the DCMI_RIS register.
    $04 constant DCMI_LINE_ISC                  \ [0x04] line interrupt status clear Setting this bit clears the LINE_RIS flag in the DCMI_RIS register.
  [then]


  [ifdef] DCMI_DCMI_ESCR_DEF
    \
    \ @brief DCMI embedded synchronization code register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FSC                       \ [0x00 : 8] Frame start delimiter code This byte specifies the code of the frame start delimiter. The code consists of 4 bytes in the form of 0xFF, 0x00, 0x00, FSC. If FSC is programmed to 0xFF, no frame start delimiter is detected. But, the first occurrence of LSC after an FEC code is interpreted as a start of frame delimiter.
    $08 constant DCMI_LSC                       \ [0x08 : 8] Line start delimiter code This byte specifies the code of the line start delimiter. The code consists of 4 bytes in the form of 0xFF, 0x00, 0x00, LSC.
    $10 constant DCMI_LEC                       \ [0x10 : 8] Line end delimiter code This byte specifies the code of the line end delimiter. The code consists of 4 bytes in the form of 0xFF, 0x00, 0x00, LEC.
    $18 constant DCMI_FEC                       \ [0x18 : 8] Frame end delimiter code This byte specifies the code of the frame end delimiter. The code consists of 4 bytes in the form of 0xFF, 0x00, 0x00, FEC. If FEC is programmed to 0xFF, all the unused codes (0xFF0000XY) are interpreted as frame end delimiters.
  [then]


  [ifdef] DCMI_DCMI_ESUR_DEF
    \
    \ @brief DCMI embedded synchronization unmask register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FSU                       \ [0x00 : 8] Frame start delimiter unmask This byte specifies the mask to be applied to the code of the frame start delimiter.
    $08 constant DCMI_LSU                       \ [0x08 : 8] Line start delimiter unmask This byte specifies the mask to be applied to the code of the line start delimiter.
    $10 constant DCMI_LEU                       \ [0x10 : 8] Line end delimiter unmask This byte specifies the mask to be applied to the code of the line end delimiter.
    $18 constant DCMI_FEU                       \ [0x18 : 8] Frame end delimiter unmask This byte specifies the mask to be applied to the code of the frame end delimiter.
  [then]


  [ifdef] DCMI_DCMI_CWSTRT_DEF
    \
    \ @brief DCMI crop window start
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_HOFFCNT                   \ [0x00 : 14] Horizontal offset count This value gives the number of pixel clocks to count before starting a capture.
    $10 constant DCMI_VST                       \ [0x10 : 13] Vertical start line count The image capture starts with this line number. Previous line data are ignored. ....
  [then]


  [ifdef] DCMI_DCMI_CWSIZE_DEF
    \
    \ @brief DCMI crop window size
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_CAPCNT                    \ [0x00 : 14] Capture count This value gives the number of pixel clocks to be captured from the starting point on the same line. It value must corresponds to word-aligned data for different widths of parallel interfaces. 0x0000 = 1 pixel 0x0001 = 2 pixels 0x0002 = 3 pixels ....
    $10 constant DCMI_VLINE                     \ [0x10 : 14] Vertical line count This value gives the number of lines to be captured from the starting point. ....
  [then]


  [ifdef] DCMI_DCMI_DR_DEF
    \
    \ @brief DCMI data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_BYTE0                     \ [0x00 : 8] Data byte 0
    $08 constant DCMI_BYTE1                     \ [0x08 : 8] Data byte 1
    $10 constant DCMI_BYTE2                     \ [0x10 : 8] Data byte 2
    $18 constant DCMI_BYTE3                     \ [0x18 : 8] Data byte 3
  [then]

  \
  \ @brief Digital camera interface
  \
  $00 constant DCMI_DCMI_CR             \ DCMI control register
  $04 constant DCMI_DCMI_SR             \ DCMI status register
  $08 constant DCMI_DCMI_RIS            \ DCMI raw interrupt status register
  $0C constant DCMI_DCMI_IER            \ DCMI interrupt enable register
  $10 constant DCMI_DCMI_MIS            \ DCMI masked interrupt status register
  $14 constant DCMI_DCMI_ICR            \ DCMI interrupt clear register
  $18 constant DCMI_DCMI_ESCR           \ DCMI embedded synchronization code register
  $1C constant DCMI_DCMI_ESUR           \ DCMI embedded synchronization unmask register
  $20 constant DCMI_DCMI_CWSTRT         \ DCMI crop window start
  $24 constant DCMI_DCMI_CWSIZE         \ DCMI crop window size
  $28 constant DCMI_DCMI_DR             \ DCMI data register

: DCMI_DEF ; [then]
