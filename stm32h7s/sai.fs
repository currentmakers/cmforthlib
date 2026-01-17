\
\ @file sai.fs
\ @brief Serial audio interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SAI_DEF

  [ifdef] SAI_SAI_GCR_DEF
    \
    \ @brief SAI global configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SAI_SYNCIN                     \ [0x00 : 2] Synchronization inputs These bits are set and cleared by software. Refer to Table 418: External synchronization selection (TinyShark, Beluga and STM32U5_Cobra2M and 4M, Viper, Mustang, Python) for information on how to program this field. These bits must be set when both audio blocks (A and B) are disabled. They are meaningful if one of the two audio blocks is defined to operate in synchronous mode with an external SAI (SYNCEN[1:0] = 10 in SAI_ACR1 or in SAI_BCR1 registers).
    $04 constant SAI_SYNCOUT                    \ [0x04 : 2] Synchronization outputs These bits are set and cleared by software.
  [then]


  [ifdef] SAI_SAI_ACR1_DEF
    \
    \ @brief SAI configuration register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000040
    \
    $00 constant SAI_MODE                       \ [0x00 : 2] SAIx audio block mode These bits are set and cleared by software. They must be configured when SAIx audio block is disabled. Note: When the audio block is configured in SPDIF mode, the master transmitter mode is forced (MODE[1:0] = 00).
    $02 constant SAI_PRTCFG                     \ [0x02 : 2] Protocol configuration These bits are set and cleared by software. These bits have to be configured when the audio block is disabled.
    $05 constant SAI_DS                         \ [0x05 : 3] Data size These bits are set and cleared by software. These bits are ignored when the SPDIF protocols are selected (bit PRTCFG[1:0]), because the frame and the data size are fixed in such case. When the companding mode is selected through COMP[1:0] bits, DS[1:0] are ignored since the data size is fixed to 8 bits by the algorithm. These bits must be configured when the audio block is disabled.
    $08 constant SAI_LSBFIRST                   \ [0x08] Least significant bit first This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in AC97 audio protocol since AC97 data are always transferred with the MSB first. This bit has no meaning in SPDIF audio protocol since in SPDIF data are always transferred with LSB first.
    $09 constant SAI_CKSTR                      \ [0x09] Clock strobing edge This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in SPDIF audio protocol.
    $0a constant SAI_SYNCEN                     \ [0x0a : 2] Synchronization enable These bits are set and cleared by software. They must be configured when the audio subblock is disabled. Note: The audio subblock should be configured as asynchronous when SPDIF mode is enabled.
    $0c constant SAI_MONO                       \ [0x0c] Mono mode This bit is set and cleared by software. It is meaningful only when the number of slots is equal to 2. When the mono mode is selected, slot 0 data are duplicated on slot 1 when the audio block operates as a transmitter. In reception mode, the slot1 is discarded and only the data received from slot 0 are stored. Refer to Section : Mono/stereo mode for more details.
    $0d constant SAI_OUTDRIV                    \ [0x0d] Output drive This bit is set and cleared by software. Note: This bit has to be set before enabling the audio block and after the audio block configuration.
    $10 constant SAI_SAIEN                      \ [0x10] Audio block enable This bit is set by software. To switch off the audio block, the application software must program this bit to 0 and poll the bit till it reads back 0, meaning that the block is completely disabled. Before setting this bit to 1, check that it is set to 0, otherwise the enable command is not taken into account. This bit enables to control the state of the SAI audio block. If it is disabled when an audio frame transfer is ongoing, the ongoing transfer completes and the cell is fully disabled at the end of this audio frame transfer. Note: When the SAI block (A or B) is configured in master mode, the clock must be present on the SAI block input before setting SAIEN bit.
    $11 constant SAI_DMAEN                      \ [0x11] DMA enable This bit is set and cleared by software. Note: Since the audio block defaults to operate as a transmitter after reset, the MODE[1:0] bits must be configured before setting DMAEN to avoid a DMA request in receiver mode.
    $13 constant SAI_NODIV                      \ [0x13] No divider This bit is set and cleared by software.
    $14 constant SAI_MCKDIV                     \ [0x14 : 6] Master clock divider These bits are set and cleared by software. Otherwise, The master clock frequency is calculated according to the formula given in Section 55.4.8: SAI clock generator. These bits have no meaning when the audio block is slave. They have to be configured when the audio block is disabled.
    $1a constant SAI_OSR                        \ [0x1a] Oversampling ratio for master clock This bit is meaningful only when NODIV bit is set to 0.
    $1b constant SAI_MCKEN                      \ [0x1b] Master clock generation enable
  [then]


  [ifdef] SAI_SAI_ACR2_DEF
    \
    \ @brief SAI configuration register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FTH                        \ [0x00 : 3] FIFO threshold. This bit is set and cleared by software.
    $03 constant SAI_FFLUSH                     \ [0x03] FIFO flush. This bit is set by software. It is always read as 0. This bit should be configured when the SAI is disabled.
    $04 constant SAI_TRIS                       \ [0x04] Tristate management on data line. This bit is set and cleared by software. It is meaningful only if the audio block is configured as a transmitter. This bit is not used when the audio block is configured in SPDIF mode. It should be configured when SAI is disabled. Refer to Section : Output data line management on an inactive slot for more details.
    $05 constant SAI_MUTE                       \ [0x05] Mute. This bit is set and cleared by software. It is meaningful only when the audio block operates as a transmitter. The MUTE value is linked to value of MUTEVAL if the number of slots is lower or equal to 2, or equal to 0 if it is greater than 2. Refer to Section : Mute mode for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
    $06 constant SAI_MUTEVAL                    \ [0x06] Mute value. This bit is set and cleared by software.It must be written before enabling the audio block: SAIEN. This bit is meaningful only when the audio block operates as a transmitter, the number of slots is lower or equal to 2 and the MUTE bit is set. If more slots are declared, the bit value sent during the transmission in mute mode is equal to 0, whatever the value of MUTEVAL. if the number of slot is lower or equal to 2 and MUTEVAL = 1, the MUTE value transmitted for each slot is the one sent during the previous frame. Refer to Section : Mute mode for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
    $07 constant SAI_MUTECNT                    \ [0x07 : 6] Mute counter. These bits are set and cleared by software. They are used only in reception mode. The value set in these bits is compared to the number of consecutive mute frames detected in reception. When the number of mute frames is equal to this value, the flag MUTEDET is set and an interrupt is generated if bit MUTEDETIE is set. Refer to Section : Mute mode for more details.
    $0d constant SAI_CPL                        \ [0x0d] Complement bit. This bit is set and cleared by software. It defines the type of complement to be used for companding mode Note: This bit has effect only when the companding mode is -Law algorithm or A-Law algorithm.
    $0e constant SAI_COMP                       \ [0x0e : 2] Companding mode. These bits are set and cleared by software. The -Law and the A-Law log are a part of the CCITT G.711 recommendation, the type of complement that is used depends on CPL bit. The data expansion or data compression are determined by the state of bit MODE[0]. The data compression is applied if the audio block is configured as a transmitter. The data expansion is automatically applied when the audio block is configured as a receiver. Refer to Section : Companding mode for more details. Note: Companding mode is applicable only when Free protocol mode is selected.
  [then]


  [ifdef] SAI_SAI_AFRCR_DEF
    \
    \ @brief SAI frame configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $00 constant SAI_FRL                        \ [0x00 : 8] Frame length. These bits are set and cleared by software. They define the audio frame length expressed in number of SCK clock cycles: the number of bits in the frame is equal to FRL[7:0] + 1. The minimum number of bits to transfer in an audio frame must be equal to 8, otherwise the audio block behaves in an unexpected way. This is the case when the data size is 8 bits and only one slot 0 is defined in NBSLOT[4:0] of SAI_xSLOTR register (NBSLOT[3:0] = 0000). In master mode, if the master clock (available on MCLK_x pin) is used, the frame length should be aligned with a number equal to a power of 2, ranging from 8 to 256. When the master clock is not used (NODIV = 1), it is recommended to program the frame length to an value ranging from 8 to 256. These bits are meaningless and are not used in AC97 or SPDIF audio block configuration. They must be configured when the audio block is disabled.
    $08 constant SAI_FSALL                      \ [0x08 : 7] Frame synchronization active level length. These bits are set and cleared by software. They specify the length in number of bit clock (SCK) + 1 (FSALL[6:0] + 1) of the active level of the FS signal in the audio frame These bits are meaningless and are not used in AC97 or SPDIF audio block configuration. They must be configured when the audio block is disabled.
    $10 constant SAI_FSDEF                      \ [0x10] Frame synchronization definition. This bit is set and cleared by software. When the bit is set, the number of slots defined in the SAI_xSLOTR register has to be even. It means that half of this number of slots are dedicated to the left channel and the other slots for the right channel (e.g: this bit has to be set for I2S or MSB/LSB-justified protocols...). This bit is meaningless and is not used in AC97 or SPDIF audio block configuration. It must be configured when the audio block is disabled.
    $11 constant SAI_FSPOL                      \ [0x11] Frame synchronization polarity. This bit is set and cleared by software. It is used to configure the level of the start of frame on the FS signal. It is meaningless and is not used in AC97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.
    $12 constant SAI_FSOFF                      \ [0x12] Frame synchronization offset. This bit is set and cleared by software. It is meaningless and is not used in AC97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.
  [then]


  [ifdef] SAI_SAI_ASLOTR_DEF
    \
    \ @brief SAI slot register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FBOFF                      \ [0x00 : 5] First bit offset These bits are set and cleared by software. The value set in this bitfield defines the position of the first data transfer bit in the slot. It represents an offset value. In transmission mode, the bits outside the data field are forced to 0. In reception mode, the extra received bits are discarded. These bits must be set when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
    $06 constant SAI_SLOTSZ                     \ [0x06 : 2] Slot size This bits is set and cleared by software. The slot size must be higher or equal to the data size. If this condition is not respected, the behavior of the SAI is undetermined. Refer to Output data line management on an inactive slot for information on how to drive SD line. These bits must be set when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
    $08 constant SAI_NBSLOT                     \ [0x08 : 4] Number of slots in an audio frame. These bits are set and cleared by software. The value set in this bitfield represents the number of slots + 1 in the audio frame (including the number of inactive slots). The maximum number of slots is 16. The number of slots should be even if FSDEF bit in the SAI_xFRCR register is set. The number of slots must be configured when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
    $10 constant SAI_SLOTEN                     \ [0x10 : 16] Slot enable. These bits are set and cleared by software. Each SLOTEN bit corresponds to a slot position from 0 to 15 (maximum 16 slots). The slot must be enabled when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
  [then]


  [ifdef] SAI_SAI_AIM_DEF
    \
    \ @brief SAI interrupt mask register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SAI_OVRUDRIE                   \ [0x00] Overrun/underrun interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the OVRUDR bit in the SAI_xSR register is set.
    $01 constant SAI_MUTEDETIE                  \ [0x01] Mute detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the MUTEDET bit in the SAI_xSR register is set. This bit has a meaning only if the audio block is configured in receiver mode.
    $02 constant SAI_WCKCFGIE                   \ [0x02] Wrong clock configuration interrupt enable. This bit is set and cleared by software. This bit is taken into account only if the audio block is configured as a master (MODE[1] = 0) and NODIV = 0. It generates an interrupt if the WCKCFG flag in the SAI_xSR register is set. Note: This bit is used only in Free protocol mode and is meaningless in other modes.
    $03 constant SAI_FREQIE                     \ [0x03] FIFO request interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the FREQ bit in the SAI_xSR register is set. Since the audio block defaults to operate as a transmitter after reset, the MODE bit must be configured before setting FREQIE to avoid a parasitic interrupt in receiver mode,
    $04 constant SAI_CNRDYIE                    \ [0x04] Codec not ready interrupt enable (AC97). This bit is set and cleared by software. When the interrupt is enabled, the audio block detects in the slot 0 (tag0) of the AC97 frame if the Codec connected to this line is ready or not. If it is not ready, the CNRDY flag in the SAI_xSR register is set and an interrupt is generated. This bit has a meaning only if the AC97 mode is selected through PRTCFG[1:0] bits and the audio block is operates as a receiver.
    $05 constant SAI_AFSDETIE                   \ [0x05] Anticipated frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the AFSDET bit in the SAI_xSR register is set. This bit is meaningless in AC97, SPDIF mode or when the audio block operates as a master.
    $06 constant SAI_LFSDETIE                   \ [0x06] Late frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the LFSDET bit is set in the SAI_xSR register. This bit is meaningless in AC97, SPDIF mode or when the audio block operates as a master.
  [then]


  [ifdef] SAI_SAI_ASR_DEF
    \
    \ @brief SAI status register
    \ Address offset: 0x18
    \ Reset value: 0x00000008
    \
    $00 constant SAI_OVRUDR                     \ [0x00] Overrun / underrun. This bit is read only. The overrun and underrun conditions can occur only when the audio block is configured as a receiver and a transmitter, respectively. It can generate an interrupt if OVRUDRIE bit is set in SAI_xIM register. This flag is cleared when the software sets COVRUDR bit in SAI_xCLRFR register.
    $01 constant SAI_MUTEDET                    \ [0x01] Mute detection. This bit is read only. This flag is set if consecutive 0 values are received in each slot of a given audio frame and for a consecutive number of audio frames (set in the MUTECNT bit in the SAI_xCR2 register). It can generate an interrupt if MUTEDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets bit CMUTEDET in the SAI_xCLRFR register.
    $02 constant SAI_WCKCFG                     \ [0x02] Wrong clock configuration flag. This bit is read only. This bit is used only when the audio block operates in master mode (MODE[1] = 0) and NODIV = 0. It can generate an interrupt if WCKCFGIE bit is set in SAI_xIM register. This flag is cleared when the software sets CWCKCFG bit in SAI_xCLRFR register.
    $03 constant SAI_FREQ                       \ [0x03] FIFO request. This bit is read only. The request depends on the audio block configuration: If the block is configured in transmission mode, the FIFO request is related to a write request operation in the SAI_xDR. If the block configured in reception, the FIFO request related to a read request operation from the SAI_xDR. This flag can generate an interrupt if FREQIE bit is set in SAI_xIM register.
    $04 constant SAI_CNRDY                      \ [0x04] Codec not ready. This bit is read only. This bit is used only when the AC97 audio protocol is selected in the SAI_xCR1 register and configured in receiver mode. It can generate an interrupt if CNRDYIE bit is set in SAI_xIM register. This flag is cleared when the software sets CCNRDY bit in SAI_xCLRFR register.
    $05 constant SAI_AFSDET                     \ [0x05] Anticipated frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC97 or SPDIF mode. It can generate an interrupt if AFSDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets CAFSDET bit in SAI_xCLRFR register.
    $06 constant SAI_LFSDET                     \ [0x06] Late frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC97 or SPDIF mode. It can generate an interrupt if LFSDETIE bit is set in the SAI_xIM register. This flag is cleared when the software sets bit CLFSDET in SAI_xCLRFR register
    $10 constant SAI_FLVL                       \ [0x10 : 3] FIFO level threshold. This bit is read only. The FIFO level threshold flag is managed only by hardware and its setting depends on SAI block configuration (transmitter or receiver mode). Others: Reserved
  [then]


  [ifdef] SAI_SAI_ACLRFR_DEF
    \
    \ @brief SAI clear flag register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SAI_COVRUDR                    \ [0x00] Clear overrun / underrun. This bit is write only. Programming this bit to 1 clears the OVRUDR flag in the SAI_xSR register. Reading this bit always returns the value 0.
    $01 constant SAI_CMUTEDET                   \ [0x01] Mute detection flag. This bit is write only. Programming this bit to 1 clears the MUTEDET flag in the SAI_xSR register. Reading this bit always returns the value 0.
    $02 constant SAI_CWCKCFG                    \ [0x02] Clear wrong clock configuration flag. This bit is write only. Programming this bit to 1 clears the WCKCFG flag in the SAI_xSR register. This bit is used only when the audio block is set as master (MODE[1] = 0) and NODIV = 0 in the SAI_xCR1 register. Reading this bit always returns the value 0.
    $04 constant SAI_CCNRDY                     \ [0x04] Clear Codec not ready flag. This bit is write only. Programming this bit to 1 clears the CNRDY flag in the SAI_xSR register. This bit is used only when the AC97 audio protocol is selected in the SAI_xCR1 register. Reading this bit always returns the value 0.
    $05 constant SAI_CAFSDET                    \ [0x05] Clear anticipated frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the AFSDET flag in the SAI_xSR register. It is not used in AC97 or SPDIF mode. Reading this bit always returns the value 0.
    $06 constant SAI_CLFSDET                    \ [0x06] Clear late frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the LFSDET flag in the SAI_xSR register. This bit is not used in AC97 or SPDIF mode Reading this bit always returns the value 0.
  [then]


  [ifdef] SAI_SAI_ADR_DEF
    \
    \ @brief SAI data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SAI_DATA                       \ [0x00 : 32] Data A write to this register loads the FIFO provided the FIFO is not full. A read from this register empties the FIFO if the FIFO is not empty.
  [then]


  [ifdef] SAI_SAI_BCR1_DEF
    \
    \ @brief SAI configuration register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000040
    \
    $00 constant SAI_MODE                       \ [0x00 : 2] SAIx audio block mode These bits are set and cleared by software. They must be configured when SAIx audio block is disabled. Note: When the audio block is configured in SPDIF mode, the master transmitter mode is forced (MODE[1:0] = 00). In Master transmitter mode, the audio block starts generating the FS and the clocks immediately.
    $02 constant SAI_PRTCFG                     \ [0x02 : 2] Protocol configuration These bits are set and cleared by software. These bits have to be configured when the audio block is disabled.
    $05 constant SAI_DS                         \ [0x05 : 3] Data size These bits are set and cleared by software. These bits are ignored when the SPDIF protocols are selected (bit PRTCFG[1:0]), because the frame and the data size are fixed in such case. When the companding mode is selected through COMP[1:0] bits, DS[1:0] are ignored since the data size is fixed to 8 bits by the algorithm. These bits must be configured when the audio block is disabled.
    $08 constant SAI_LSBFIRST                   \ [0x08] Least significant bit first This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in AC97 audio protocol since AC97 data are always transferred with the MSB first. This bit has no meaning in SPDIF audio protocol since in SPDIF data are always transferred with LSB first.
    $09 constant SAI_CKSTR                      \ [0x09] Clock strobing edge This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in SPDIF audio protocol.
    $0a constant SAI_SYNCEN                     \ [0x0a : 2] Synchronization enable These bits are set and cleared by software. They must be configured when the audio subblock is disabled. Note: The audio subblock should be configured as asynchronous when SPDIF mode is enabled.
    $0c constant SAI_MONO                       \ [0x0c] Mono mode This bit is set and cleared by software. It is meaningful only when the number of slots is equal to 2. When the mono mode is selected, slot 0 data are duplicated on slot 1 when the audio block operates as a transmitter. In reception mode, the slot1 is discarded and only the data received from slot 0 are stored. Refer to Section : Mono/stereo mode for more details.
    $0d constant SAI_OUTDRIV                    \ [0x0d] Output drive This bit is set and cleared by software. Note: This bit has to be set before enabling the audio block and after the audio block configuration.
    $10 constant SAI_SAIEN                      \ [0x10] Audio block enable This bit is set by software. To switch off the audio block, the application software must program this bit to 0 and poll the bit till it reads back 0, meaning that the block is completely disabled. Before setting this bit to 1, check that it is set to 0, otherwise the enable command is not taken into account. This bit enables to control the state of the SAI audio block. If it is disabled when an audio frame transfer is ongoing, the ongoing transfer completes and the cell is fully disabled at the end of this audio frame transfer. Note: When the SAI block (A or B) is configured in master mode, the clock must be present on the SAI block input before setting SAIEN bit.
    $11 constant SAI_DMAEN                      \ [0x11] DMA enable This bit is set and cleared by software. Note: Since the audio block defaults to operate as a transmitter after reset, the MODE[1:0] bits must be configured before setting DMAEN to avoid a DMA request in receiver mode.
    $13 constant SAI_NODIV                      \ [0x13] No divider This bit is set and cleared by software.
    $14 constant SAI_MCKDIV                     \ [0x14 : 6] Master clock divider These bits are set and cleared by software. Otherwise, The master clock frequency is calculated according to the formula given in Section 55.4.8: SAI clock generator. These bits have no meaning when the audio block is slave. They have to be configured when the audio block is disabled.
    $1a constant SAI_OSR                        \ [0x1a] Oversampling ratio for master clock This bit is meaningful only when NODIV bit is set to 0.
    $1b constant SAI_MCKEN                      \ [0x1b] Master clock generation enable
  [then]


  [ifdef] SAI_SAI_BCR2_DEF
    \
    \ @brief SAI configuration register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FTH                        \ [0x00 : 3] FIFO threshold. This bit is set and cleared by software.
    $03 constant SAI_FFLUSH                     \ [0x03] FIFO flush. This bit is set by software. It is always read as 0. This bit should be configured when the SAI is disabled.
    $04 constant SAI_TRIS                       \ [0x04] Tristate management on data line. This bit is set and cleared by software. It is meaningful only if the audio block is configured as a transmitter. This bit is not used when the audio block is configured in SPDIF mode. It should be configured when SAI is disabled. Refer to Section : Output data line management on an inactive slot for more details.
    $05 constant SAI_MUTE                       \ [0x05] Mute. This bit is set and cleared by software. It is meaningful only when the audio block operates as a transmitter. The MUTE value is linked to value of MUTEVAL if the number of slots is lower or equal to 2, or equal to 0 if it is greater than 2. Refer to Section : Mute mode for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
    $06 constant SAI_MUTEVAL                    \ [0x06] Mute value. This bit is set and cleared by software.It must be written before enabling the audio block: SAIEN. This bit is meaningful only when the audio block operates as a transmitter, the number of slots is lower or equal to 2 and the MUTE bit is set. If more slots are declared, the bit value sent during the transmission in mute mode is equal to 0, whatever the value of MUTEVAL. if the number of slot is lower or equal to 2 and MUTEVAL = 1, the MUTE value transmitted for each slot is the one sent during the previous frame. Refer to Section : Mute mode for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
    $07 constant SAI_MUTECNT                    \ [0x07 : 6] Mute counter. These bits are set and cleared by software. They are used only in reception mode. The value set in these bits is compared to the number of consecutive mute frames detected in reception. When the number of mute frames is equal to this value, the flag MUTEDET is set and an interrupt is generated if bit MUTEDETIE is set. Refer to Section : Mute mode for more details.
    $0d constant SAI_CPL                        \ [0x0d] Complement bit. This bit is set and cleared by software. It defines the type of complement to be used for companding mode Note: This bit has effect only when the companding mode is -Law algorithm or A-Law algorithm.
    $0e constant SAI_COMP                       \ [0x0e : 2] Companding mode. These bits are set and cleared by software. The -Law and the A-Law log are a part of the CCITT G.711 recommendation, the type of complement that is used depends on CPL bit. The data expansion or data compression are determined by the state of bit MODE[0]. The data compression is applied if the audio block is configured as a transmitter. The data expansion is automatically applied when the audio block is configured as a receiver. Refer to Section : Companding mode for more details. Note: Companding mode is applicable only when Free protocol mode is selected.
  [then]


  [ifdef] SAI_SAI_BFRCR_DEF
    \
    \ @brief SAI frame configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000007
    \
    $00 constant SAI_FRL                        \ [0x00 : 8] Frame length. These bits are set and cleared by software. They define the audio frame length expressed in number of SCK clock cycles: the number of bits in the frame is equal to FRL[7:0] + 1. The minimum number of bits to transfer in an audio frame must be equal to 8, otherwise the audio block behaves in an unexpected way. This is the case when the data size is 8 bits and only one slot 0 is defined in NBSLOT[4:0] of SAI_xSLOTR register (NBSLOT[3:0] = 0000). In master mode, if the master clock (available on MCLK_x pin) is used, the frame length should be aligned with a number equal to a power of 2, ranging from 8 to 256. When the master clock is not used (NODIV = 1), it is recommended to program the frame length to an value ranging from 8 to 256. These bits are meaningless and are not used in AC97 or SPDIF audio block configuration.
    $08 constant SAI_FSALL                      \ [0x08 : 7] Frame synchronization active level length. These bits are set and cleared by software. They specify the length in number of bit clock (SCK) + 1 (FSALL[6:0] + 1) of the active level of the FS signal in the audio frame These bits are meaningless and are not used in AC97 or SPDIF audio block configuration. They must be configured when the audio block is disabled.
    $10 constant SAI_FSDEF                      \ [0x10] Frame synchronization definition. This bit is set and cleared by software. When the bit is set, the number of slots defined in the SAI_xSLOTR register has to be even. It means that half of this number of slots is dedicated to the left channel and the other slots for the right channel (e.g: this bit has to be set for I2S or MSB/LSB-justified protocols...). This bit is meaningless and is not used in AC97 or SPDIF audio block configuration. It must be configured when the audio block is disabled.
    $11 constant SAI_FSPOL                      \ [0x11] Frame synchronization polarity. This bit is set and cleared by software. It is used to configure the level of the start of frame on the FS signal. It is meaningless and is not used in AC97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.
    $12 constant SAI_FSOFF                      \ [0x12] Frame synchronization offset. This bit is set and cleared by software. It is meaningless and is not used in AC97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.
  [then]


  [ifdef] SAI_SAI_BSLOTR_DEF
    \
    \ @brief SAI slot register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FBOFF                      \ [0x00 : 5] First bit offset These bits are set and cleared by software. The value set in this bitfield defines the position of the first data transfer bit in the slot. It represents an offset value. In transmission mode, the bits outside the data field are forced to 0. In reception mode, the extra received bits are discarded. These bits must be set when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
    $06 constant SAI_SLOTSZ                     \ [0x06 : 2] Slot size This bits is set and cleared by software. The slot size must be higher or equal to the data size. If this condition is not respected, the behavior of the SAI is undetermined. Refer to Output data line management on an inactive slot for information on how to drive SD line. These bits must be set when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
    $08 constant SAI_NBSLOT                     \ [0x08 : 4] Number of slots in an audio frame. These bits are set and cleared by software. The value set in this bitfield represents the number of slots + 1 in the audio frame (including the number of inactive slots). The maximum number of slots is 16. The number of slots should be even if FSDEF bit in the SAI_xFRCR register is set. The number of slots must be configured when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
    $10 constant SAI_SLOTEN                     \ [0x10 : 16] Slot enable. These bits are set and cleared by software. Each SLOTEN bit corresponds to a slot position from 0 to 15 (maximum 16 slots). The slot must be enabled when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
  [then]


  [ifdef] SAI_SAI_BIM_DEF
    \
    \ @brief SAI interrupt mask register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SAI_OVRUDRIE                   \ [0x00] Overrun/underrun interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the OVRUDR bit in the SAI_xSR register is set.
    $01 constant SAI_MUTEDETIE                  \ [0x01] Mute detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the MUTEDET bit in the SAI_xSR register is set. This bit has a meaning only if the audio block is configured in receiver mode.
    $02 constant SAI_WCKCFGIE                   \ [0x02] Wrong clock configuration interrupt enable. This bit is set and cleared by software. This bit is taken into account only if the audio block is configured as a master (MODE[1] = 0) and NODIV = 0. It generates an interrupt if the WCKCFG flag in the SAI_xSR register is set. Note: This bit is used only in Free protocol mode and is meaningless in other modes.
    $03 constant SAI_FREQIE                     \ [0x03] FIFO request interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the FREQ bit in the SAI_xSR register is set. Since the audio block defaults to operate as a transmitter after reset, the MODE bit must be configured before setting FREQIE to avoid a parasitic interrupt in receiver mode,
    $04 constant SAI_CNRDYIE                    \ [0x04] Codec not ready interrupt enable (AC97). This bit is set and cleared by software. When the interrupt is enabled, the audio block detects in the slot 0 (tag0) of the AC97 frame if the Codec connected to this line is ready or not. If it is not ready, the CNRDY flag in the SAI_xSR register is set and an interrupt is generated. This bit has a meaning only if the AC97 mode is selected through PRTCFG[1:0] bits and the audio block is operates as a receiver.
    $05 constant SAI_AFSDETIE                   \ [0x05] Anticipated frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the AFSDET bit in the SAI_xSR register is set. This bit is meaningless in AC97, SPDIF mode or when the audio block operates as a master.
    $06 constant SAI_LFSDETIE                   \ [0x06] Late frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the LFSDET bit is set in the SAI_xSR register. This bit is meaningless in AC97, SPDIF mode or when the audio block operates as a master.
  [then]


  [ifdef] SAI_SAI_BSR_DEF
    \
    \ @brief SAI status register
    \ Address offset: 0x38
    \ Reset value: 0x00000008
    \
    $00 constant SAI_OVRUDR                     \ [0x00] Overrun / underrun. This bit is read only. The overrun and underrun conditions can occur only when the audio block is configured as a receiver and a transmitter, respectively. It can generate an interrupt if OVRUDRIE bit is set in SAI_xIM register. This flag is cleared when the software sets COVRUDR bit in SAI_xCLRFR register.
    $01 constant SAI_MUTEDET                    \ [0x01] Mute detection. This bit is read only. This flag is set if consecutive 0 values are received in each slot of a given audio frame and for a consecutive number of audio frames (set in the MUTECNT bit in the SAI_xCR2 register). It can generate an interrupt if MUTEDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets bit CMUTEDET in the SAI_xCLRFR register.
    $02 constant SAI_WCKCFG                     \ [0x02] Wrong clock configuration flag. This bit is read only. This bit is used only when the audio block operates in master mode (MODE[1] = 0) and NODIV = 0. It can generate an interrupt if WCKCFGIE bit is set in SAI_xIM register. This flag is cleared when the software sets CWCKCFG bit in SAI_xCLRFR register.
    $03 constant SAI_FREQ                       \ [0x03] FIFO request. This bit is read only. The request depends on the audio block configuration: If the block is configured in transmission mode, the FIFO request is related to a write request operation in the SAI_xDR. If the block configured in reception, the FIFO request related to a read request operation from the SAI_xDR. This flag can generate an interrupt if FREQIE bit is set in SAI_xIM register.
    $04 constant SAI_CNRDY                      \ [0x04] Codec not ready. This bit is read only. This bit is used only when the AC97 audio protocol is selected in the SAI_xCR1 register and configured in receiver mode. It can generate an interrupt if CNRDYIE bit is set in SAI_xIM register. This flag is cleared when the software sets CCNRDY bit in SAI_xCLRFR register.
    $05 constant SAI_AFSDET                     \ [0x05] Anticipated frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC97or SPDIF mode. It can generate an interrupt if AFSDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets CAFSDET bit in SAI_xCLRFR register.
    $06 constant SAI_LFSDET                     \ [0x06] Late frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC97 or SPDIF mode. It can generate an interrupt if LFSDETIE bit is set in the SAI_xIM register. This flag is cleared when the software sets bit CLFSDET in SAI_xCLRFR register
    $10 constant SAI_FLVL                       \ [0x10 : 3] FIFO level threshold. This bit is read only. The FIFO level threshold flag is managed only by hardware and its setting depends on SAI block configuration (transmitter or receiver mode). Others: Reserved
  [then]


  [ifdef] SAI_SAI_BCLRFR_DEF
    \
    \ @brief SAI clear flag register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SAI_COVRUDR                    \ [0x00] Clear overrun / underrun. This bit is write only. Programming this bit to 1 clears the OVRUDR flag in the SAI_xSR register. Reading this bit always returns the value 0.
    $01 constant SAI_CMUTEDET                   \ [0x01] Mute detection flag. This bit is write only. Programming this bit to 1 clears the MUTEDET flag in the SAI_xSR register. Reading this bit always returns the value 0.
    $02 constant SAI_CWCKCFG                    \ [0x02] Clear wrong clock configuration flag. This bit is write only. Programming this bit to 1 clears the WCKCFG flag in the SAI_xSR register. This bit is used only when the audio block is set as master (MODE[1] = 0) and NODIV = 0 in the SAI_xCR1 register. Reading this bit always returns the value 0.
    $04 constant SAI_CCNRDY                     \ [0x04] Clear Codec not ready flag. This bit is write only. Programming this bit to 1 clears the CNRDY flag in the SAI_xSR register. This bit is used only when the AC97 audio protocol is selected in the SAI_xCR1 register. Reading this bit always returns the value 0.
    $05 constant SAI_CAFSDET                    \ [0x05] Clear anticipated frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the AFSDET flag in the SAI_xSR register. It is not used in AC97or SPDIF mode. Reading this bit always returns the value 0.
    $06 constant SAI_CLFSDET                    \ [0x06] Clear late frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the LFSDET flag in the SAI_xSR register. This bit is not used in AC97or SPDIF mode Reading this bit always returns the value 0.
  [then]


  [ifdef] SAI_SAI_BDR_DEF
    \
    \ @brief SAI data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SAI_DATA                       \ [0x00 : 32] Data A write to this register loads the FIFO provided the FIFO is not full. A read from this register empties the FIFO if the FIFO is not empty.
  [then]


  [ifdef] SAI_SAI_PDMCR_DEF
    \
    \ @brief SAI PDM control register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SAI_PDMEN                      \ [0x00] PDM enable This bit is set and cleared by software. This bit enables to control the state of the PDM interface block. Make sure that the SAI in already operating in TDM master mode before enabling the PDM interface.
    $04 constant SAI_MICNBR                     \ [0x04 : 2] Number of microphones This bit is set and cleared by software. Note: It is not recommended to configure this field when PDMEN = 1.* Note: The complete set of data lines might not be available for all SAI instances. Refer to Section 55.3: SAI implementation for details.
    $08 constant SAI_CKEN1                      \ [0x08] Clock enable of bitstream clock number 1 This bit is set and cleared by software. Note: It is not recommended to configure this bit when PDMEN = 1. Note: SAI_CK1 might not be available for all SAI instances. Refer to Section 55.3: SAI implementation for details.
    $09 constant SAI_CKEN2                      \ [0x09] Clock enable of bitstream clock number 2 This bit is set and cleared by software. Note: It is not recommended to configure this bit when PDMEN = 1. Note: SAI_CK2 might not be available for all SAI instances. Refer to Section 55.3: SAI implementation for details.
  [then]


  [ifdef] SAI_SAI_PDMDLY_DEF
    \
    \ @brief SAI PDM delay register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SAI_DLYM1L                     \ [0x00 : 3] Delay line adjust for first microphone of pair 1 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D1 line is available.Refer to Section 55.3: SAI implementation to check if it is available.
    $04 constant SAI_DLYM1R                     \ [0x04 : 3] Delay line adjust for second microphone of pair 1 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D1 line is available.Refer to Section 55.3: SAI implementation to check if it is available.
    $08 constant SAI_DLYM2L                     \ [0x08 : 3] Delay line for first microphone of pair 2 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D2 line is available.Refer to Section 55.3: SAI implementation to check if it is available.
    $0c constant SAI_DLYM2R                     \ [0x0c : 3] Delay line for second microphone of pair 2 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D2 line is available.Refer to Section 55.3: SAI implementation to check if it is available.
    $10 constant SAI_DLYM3L                     \ [0x10 : 3] Delay line for first microphone of pair 3 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D3 line is available.Refer to Section 55.3: SAI implementation to check if it is available.
    $14 constant SAI_DLYM3R                     \ [0x14 : 3] Delay line for second microphone of pair 3 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D3 line is available.Refer to Section 55.3: SAI implementation to check if it is available.
    $18 constant SAI_DLYM4L                     \ [0x18 : 3] Delay line for first microphone of pair 4 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D4 line is available.Refer to Section 55.3: SAI implementation to check if it is available.
    $1c constant SAI_DLYM4R                     \ [0x1c : 3] Delay line for second microphone of pair 4 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D4 line is available.Refer to Section 55.3: SAI implementation to check if it is available.
  [then]

  \
  \ @brief Serial audio interface
  \
  $00 constant SAI_SAI_GCR              \ SAI global configuration register
  $04 constant SAI_SAI_ACR1             \ SAI configuration register 1
  $08 constant SAI_SAI_ACR2             \ SAI configuration register 2
  $0C constant SAI_SAI_AFRCR            \ SAI frame configuration register
  $10 constant SAI_SAI_ASLOTR           \ SAI slot register
  $14 constant SAI_SAI_AIM              \ SAI interrupt mask register
  $18 constant SAI_SAI_ASR              \ SAI status register
  $1C constant SAI_SAI_ACLRFR           \ SAI clear flag register
  $20 constant SAI_SAI_ADR              \ SAI data register
  $24 constant SAI_SAI_BCR1             \ SAI configuration register 1
  $28 constant SAI_SAI_BCR2             \ SAI configuration register 2
  $2C constant SAI_SAI_BFRCR            \ SAI frame configuration register
  $30 constant SAI_SAI_BSLOTR           \ SAI slot register
  $34 constant SAI_SAI_BIM              \ SAI interrupt mask register
  $38 constant SAI_SAI_BSR              \ SAI status register
  $3C constant SAI_SAI_BCLRFR           \ SAI clear flag register
  $40 constant SAI_SAI_BDR              \ SAI data register
  $44 constant SAI_SAI_PDMCR            \ SAI PDM control register
  $48 constant SAI_SAI_PDMDLY           \ SAI PDM delay register

: SAI_DEF ; [then]
